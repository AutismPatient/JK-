using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ppl.New;
using ppl.NewsManger.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ppl.JklConsts;

namespace ppl.NewsManger
{
    public interface INewsMangerAppService: IAsyncCrudAppService<NewsDto, Guid, PagedResultRequestDto, CreateOrUpdateNewsDto, NewsDto>
    {
        Task CreateTagAndNews(string TagListName, Guid NewsId);
        Task DeleteSingle(Guid Id);
        Task<GetNewsEdit> GetNewsEdit(Abp.Application.Services.Dto.EntityDto<Guid> entity);
        List<NewsDto> GetAll();
        Task UpdateSingle(CreateOrUpdateNewsDto input, string taglist, string url);
        Task CreateSingle(CreateOrUpdateNewsDto createOrUpdateNewsDto, string taglist, string url);
        Task Recover(Guid id);
        Task BatchRecover(string GuidList);
        Task BatchDelete(string ListGuid);
        Task Audital(Guid Id, Status select);
    }
}
