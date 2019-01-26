using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ppl.NewsCategorys.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys
{
    public interface INewsCategoryAppService 
    {
        Task Create(NewsCategoryDto categoryDto);
        Task Update(CreateOrUpdateCategoryDto updateCategoryDto);
        Task Recover(Guid id);
        Task BatchRecover(string GuidList);
        Task Delete(Guid entity);
        Task BatchDelete(string ListGuid);
        Task<CreateOrUpdateCategoryDto> GetCategoryEdit(EntityDto<Guid> entity);
        Task<IReadOnlyList<NewsCategoryDto>> GetAll();
    }
}
