using ppl.FeedBack.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.FeedBack
{
    public interface IFeedBackAppService
    {
        Task<List<FeedBackDto>> GetAll();
        Task SendToUsers(SeedDto seed);
        Task BatchDelete(string ListGuid);
        Task Delete(int Id);
        Task Create(CreateOrUpdateDto input);
        Task<FeedBackDto> GetEditModel(int id);
    }
}
