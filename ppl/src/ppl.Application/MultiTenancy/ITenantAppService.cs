using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ppl.MultiTenancy.Dto;

namespace ppl.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
