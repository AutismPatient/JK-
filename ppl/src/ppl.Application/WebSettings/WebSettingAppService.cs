using Abp.Authorization;
using Abp.Domain.Repositories;
using ppl.Authorization;
using ppl.WebSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.WebSettings
{
    [AbpAuthorize(PermissionNames.Pages_WebParameter)]
    public class WebSettingAppService:pplAppServiceBase,IWebSettingAppService
    {
        private readonly IRepository<WebSetting,Guid> _repository;
        public WebSettingAppService(IRepository<WebSetting, Guid> repository)
        {
            _repository = repository;
        }
        [AbpAuthorize(PermissionNames.Pages_EditWebSetting)]
        public async Task UpdateSingle(CreateOrUpdateDto input)
        {
            var single =await _repository.FirstOrDefaultAsync(input.Id);
            var model = ObjectMapper.Map(input,single);
            await _repository.UpdateAsync(model);
        }
        [AbpAllowAnonymous]
        public async Task<GetWebSettingEditDto> GetSingleEdit(Guid input)
        {
            var single= await _repository.FirstOrDefaultAsync(input);
            var dto = ObjectMapper.Map<GetWebSettingEditDto>(single);
            return dto;
        }
        [AbpAllowAnonymous]
        public Guid GuidAsync()
        {
            return _repository.GetAllListAsync().Result.Select(x => x.Id).FirstOrDefault();
        }
    }
}
