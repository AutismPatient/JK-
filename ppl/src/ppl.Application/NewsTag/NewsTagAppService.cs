using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.UI;
using ppl.Authorization;
using ppl.NewsTag.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsTag
{
    [AbpAuthorize(PermissionNames.Pages_Tags)]
    public class NewsTagAppService:pplAppServiceBase,INewsTagAppService
    {
        protected readonly IRepository<NewsTags,Guid> _tagRepository;
        private readonly IObjectMapper _objectMapper;
        public NewsTagAppService(IRepository<NewsTags,Guid> repository, IObjectMapper objectMapper)
        {
            _tagRepository = repository;
            _objectMapper = objectMapper;
        }
        [AbpAuthorize(PermissionNames.Pages_CreateTag)]
        public async Task Create(TagDto input)
        {
            var tag = _objectMapper.Map<NewsTags>(input);
            await _tagRepository.InsertAsync(tag);
        }

        public async Task Update(TagInput input)
        {
            var tag = await _tagRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
            var single = _objectMapper.Map(input,tag);
            await this.UpdateAsync(single);
        }
        public async Task Delete(Guid entity)
        {
            var tagsingle = await _tagRepository.GetAsync(entity);

            await this.DeleteAsync(tagsingle);
        }

        public async Task<GetTagEdit> GetTagEdit(EntityDto<Guid> entity)
        {
            var tag = await _tagRepository.GetAsync(entity.Id);
            return new GetTagEdit()
            {
                TagName =tag.TagName,
                Id=tag.Id,
                CreationTime=tag.CreationTime
            };
        }
        [AbpAllowAnonymous]
        public async Task<IReadOnlyList<TagDto>> GetAll()
        {
            return ObjectMapper.Map<IReadOnlyList<TagDto>>(await this._tagRepository.GetAllListAsync(x=>!x.IsDeleted));
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ListGuid"></param>
        /// <returns></returns>
        public async Task BatchDelete(string ListGuid)
        {
            string[] str = ListGuid.Split(',');
            foreach (var s in str)
            {
                var tags = await this._tagRepository.GetAsync(new Guid(s));
                await this.DeleteAsync(tags);
            }
        }
        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Recover(Guid id)
        {
            var tag = await this._tagRepository.FirstOrDefaultAsync(x => x.Id == id);
            tag.IsDeleted = false;
            await this.UpdateAsync(tag);
        }
        public async Task BatchRecover(string GuidList)
        {
            string[] str = GuidList.Split(',');
            foreach (var s in str)
            {
                var tag = await this._tagRepository.GetAsync(new Guid(s));
                tag.IsDeleted = false;
                await this.UpdateAsync(tag);
            }
        }
        public async Task DeleteAsync(NewsTags tags)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_DeleteTag))
                throw new UserFriendlyException("您没有权限！");
            await _tagRepository.DeleteAsync(tags);
        }
        public async Task UpdateAsync(NewsTags tags)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_UpdateData))
                throw new UserFriendlyException("您没有权限！");
            await _tagRepository.UpdateAsync(tags);
        }
    }
}
