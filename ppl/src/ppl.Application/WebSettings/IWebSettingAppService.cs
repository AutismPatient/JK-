using ppl.WebSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.WebSettings
{
    public interface IWebSettingAppService
    {
        Task UpdateSingle(CreateOrUpdateDto input);
        Task<GetWebSettingEditDto> GetSingleEdit(Guid input);
        Guid GuidAsync();
    }
}
