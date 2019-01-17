using ppl.Home.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Home
{
    public interface IHomeAppService
    {
        Task<HomeModelDto> HomeCountAsync();
    }
}
