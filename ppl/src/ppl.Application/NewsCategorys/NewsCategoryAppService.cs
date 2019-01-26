using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.UI;
using ppl.Authorization;
using ppl.NewsCategorys.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys
{
    [AbpAuthorize(PermissionNames.Pages_Category)]
    public class NewsCategoryAppService : pplAppServiceBase, INewsCategoryAppService
    {
        protected readonly IRepository<NewsCategory, Guid> _categoryRepository;
        private readonly IObjectMapper _objectMapper;
        public NewsCategoryAppService(IRepository<NewsCategory, Guid> repository, IObjectMapper objectMapper)
        {
            _categoryRepository = repository;
            _objectMapper = objectMapper;
        }
        [AbpAuthorize(PermissionNames.Pages_CreateCategory)]
        public async Task Create(NewsCategoryDto categoryDto)
        {
            var category = _objectMapper.Map<NewsCategory>(categoryDto);
            await this._categoryRepository.InsertAsync(category);
        }
        [AbpAuthorize(PermissionNames.Pages_UpdateCategory)]
        public async Task Update(CreateOrUpdateCategoryDto updateCategoryDto)
        {
            var category = await this._categoryRepository.FirstOrDefaultAsync(x => x.Id == updateCategoryDto.Id);
            var single = _objectMapper.Map(updateCategoryDto, category);
            await this.UpdateAsync(single);
        }
        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Recover(Guid id)
        {
            var category = await this._categoryRepository.FirstOrDefaultAsync(x => x.Id == id);
            category.IsDeleted = false;
            await this.UpdateAsync(category);
        }
        public async Task UpdateAsync(NewsCategory category)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_UpdateCategory))
                throw new UserFriendlyException("您没有权限！");
            await _categoryRepository.UpdateAsync(category);
        }
        public async Task BatchRecover(string GuidList)
        {
            string[] str = GuidList.Split(',');
            foreach (var s in str)
            {
                var category = await this._categoryRepository.GetAsync(new Guid(s));
                category.IsDeleted = false;
                await this.UpdateAsync(category);
            }
        }
        public async Task DeleteAsync(NewsCategory category)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_DeleteCategory))
                throw new UserFriendlyException("您没有权限！");
            await _categoryRepository.DeleteAsync(category);
        }
        public async Task Delete(Guid entity)
        {
            var categorySingle = await this._categoryRepository.GetAsync(entity);
            await this.DeleteAsync(categorySingle);
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
                var category = await this._categoryRepository.GetAsync(new Guid(s));
                await this.DeleteAsync(category);
            }
        }
        public async Task<CreateOrUpdateCategoryDto> GetCategoryEdit(EntityDto<Guid> entity)
        {
            var single = await _categoryRepository.GetAsync(entity.Id);
            return new CreateOrUpdateCategoryDto()
            {
                Id = single.Id,
                CreationTime = single.CreationTime,
                CategoryName = single.CategoryName
            };
        }
        [AbpAllowAnonymous]
        public async Task<IReadOnlyList<NewsCategoryDto>> GetAll()
        {
            return ObjectMapper.Map<IReadOnlyList<NewsCategoryDto>>(await _categoryRepository.GetAllListAsync());
        }
    }
}
