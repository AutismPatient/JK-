using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Localization;
using Abp.MultiTenancy;
using Abp.Runtime.Session;
using Abp.UI;
using ppl.Languages.Dto;
using ppl.Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages
{
    /// <summary>
    /// 主机方管理的本地化语言服务
    /// </summary>
    public class LanguagesAppService:pplAppServiceBase,ILanguagesAppService
    {
        private readonly IApplicationLanguageManager _languages;
        private readonly IApplicationLanguageTextManager _applicationLanguageTextManager;
        private readonly IAbpSession _abpSession;

        private readonly IRepository<ApplicationLanguage> _languagesAppService;
        public LanguagesAppService(
            IApplicationLanguageManager languages, 
            IRepository<ApplicationLanguage> languagesAppService,
            IApplicationLanguageTextManager applicationLanguageTextManager, IAbpSession abpSession)
        {
            _languages = languages;
            _languagesAppService = languagesAppService;
            _abpSession = abpSession;
            _applicationLanguageTextManager = applicationLanguageTextManager;
        }
        public async Task<LanguagesOutput> GetLanguagesAsync()
        {
            var languages = (await _languages.GetLanguagesAsync(_abpSession.TenantId)).Where(x=>!x.IsDeleted).OrderByDescending(l => l.DisplayName);
            var defaultLanguage = await _languages.GetDefaultLanguageOrNullAsync(tenantId:null);

            return new LanguagesOutput(
                ObjectMapper.Map<List<LanguagesDto>>(languages),
                defaultLanguage?.Name
                )
            {
                LanguageNames=CultureHelper
                .AllCultures
                .Select(s=>new ComboboxItemDto(s.Name, s.EnglishName + "(" + s.Name + ")")).ToList(),
                Flags=FamFamFamFlagsHelper
                .FlagClassNames.Select(s=>new ComboboxItemDto(s, FamFamFamFlagsHelper.GetCountryCode(s))).ToList()
            };
        }
        /// <summary>
        /// 获取语言编辑
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetLanguageForEditOutput> GetLanguaesEditAsync(NullableIdDto input)
        {
            ApplicationLanguage language = null;
            if (input.Id.HasValue)
            {
                language = await _languagesAppService.GetAsync(input.Id.Value);
            }

            var output = new GetLanguageForEditOutput();

            //Language
            output.Language = language != null
                ? ObjectMapper.Map<LanguageEditDto>(language)
                : new LanguageEditDto();

            //Language names
            output.LanguageNames = CultureHelper
                .AllCultures
                .Select(c => new ComboboxItemDto(c.Name, c.EnglishName + " (" + c.Name + ")") { IsSelected = output.Language.Name == c.Name })
                .ToList();

            //Flags
            output.Flags = FamFamFamFlagsHelper
                .FlagClassNames
                .OrderBy(f => f)
                .Select(f => new ComboboxItemDto(f, FamFamFamFlagsHelper.GetCountryCode(f)) { IsSelected = output.Language.Icon == f})
                .ToList();

            return output;
        }
        /// <summary>
        /// 创建语言
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public  async Task CreateLanguage(LanguagesInput input)
        {
            if (AbpSession.MultiTenancySide != MultiTenancySides.Host)
            {
                throw new UserFriendlyException(L("TenantsCannotCreateLanguage"));
            }
            var culture = CultureHelper.GetCultureInfoByChecking(input.Language.Name);

            await CheckLanguageIfAlreadyExists(culture.Name);

            await _languages.AddAsync(
                new ApplicationLanguage(
                    null,
                    culture.Name,
                    culture.DisplayName,
                    input.Language.Icon
                )
                {
                    IsDisabled = !input.Language.IsDisabled
                }
            );
        }
        public virtual async Task UpdateLanguage(LanguagesInput input)
        {
            var culture = CultureHelper.GetCultureInfoByChecking(input.Language.Name);

            await CheckLanguageIfAlreadyExists(culture.Name, input.Language.Id.Value);

            var language = await _languagesAppService.GetAsync(input.Language.Id.Value);

            language.Name = culture.Name;
            language.DisplayName = culture.DisplayName;
            language.Icon = input.Language.Icon;
            language.IsDisabled = !input.Language.IsDisabled;

            await _languages.UpdateAsync(AbpSession.TenantId, language);
        }
        /// <summary>
        /// 删除语言
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task DeleteLanguage(EntityDto input)
        {
            var language = await _languagesAppService.GetAsync(input.Id);
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.SoftDelete))
            {
                await _languages.RemoveAsync(AbpSession.TenantId, language.Name);
            }
        }
        public async Task UpdateLanguageText(UpdateLanguageTextInput input)
        {
            var culture = CultureHelper.GetCultureInfoByChecking(input.LanguageName);
            var source = LocalizationManager.GetSource(input.SourceName);
            await _applicationLanguageTextManager.UpdateStringAsync(AbpSession.TenantId, source.Name, culture, input.Key, input.Value);
        }
        /// <summary>
        /// 检测语言是否已存在
        /// </summary>
        /// <param name="languageName"></param>
        /// <param name="expectedId"></param>
        /// <returns></returns>
        private async Task CheckLanguageIfAlreadyExists(string languageName, int? expectedId = null)
        {
            var existingLanguage = (await _languages.GetLanguagesAsync(AbpSession.TenantId))
                .FirstOrDefault(l => l.Name == languageName);

            if (existingLanguage == null)
            {
                return;
            }

            if (expectedId != null && existingLanguage.Id == expectedId.Value)
            {
                return;
            }

            throw new UserFriendlyException("此语言已经存在数据库中！");
        }
        
        
        //public async Task<IReadOnlyList<LanguagesDto>> GetAsync()
        //{
        //    return ObjectMapper.Map<IReadOnlyList<LanguagesDto>>
        //        (await _languagesAppService.GetLanguagesAsync(tenantId:null));
        //}
        //public async Task UpdateAsync(LanguagesInput input)
        //{
        //    await _languagesAppService.UpdateAsync(
        //        AbpSession.TenantId.Value,
        //        ObjectMapper.Map(
        //            input,
        //            await _Languages.GetAsync(input.Id))
        //        );
        //}
        //public async Task CreateAsync(LanguagesInput input)
        //{
        //    await _languagesAppService.AddAsync(
        //        ObjectMapper.Map<ApplicationLanguage>(input)
        //        );
        //}
        //public  async Task DeleteAsync(int Id)
        //{
        //    await _languagesAppService.RemoveAsync(
        //        tenantId:AbpSession.TenantId.Value,
        //        languageName:
        //        _Languages.GetAsync(Id).Result.Name
        //        );
        //}
    }
}
