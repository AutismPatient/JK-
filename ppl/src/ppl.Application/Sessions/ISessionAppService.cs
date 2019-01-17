using System.Threading.Tasks;
using Abp.Application.Services;
using ppl.Sessions.Dto;

namespace ppl.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
