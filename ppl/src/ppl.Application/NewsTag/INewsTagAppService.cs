using Abp.Application.Services.Dto;
using ppl.NewsTag.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsTag
{
    public interface INewsTagAppService
    {
        Task Create(TagDto input);
        Task Update(TagInput input);
        Task Delete(Guid entity);
        Task<List<NewsTags>> GetAll();
        Task BatchDelete(string ListGuid);
        Task Recover(Guid id);
        Task BatchRecover(string GuidList);
        Task<GetTagEdit> GetTagEdit(EntityDto<Guid> entity);
    }
}
