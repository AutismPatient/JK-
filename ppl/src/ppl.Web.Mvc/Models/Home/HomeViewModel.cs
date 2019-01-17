using Abp.AutoMapper;
using ppl.Home.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Home
{
    [AutoMapFrom(typeof(HomeModelDto))]
    public class HomeViewModel:HomeModelDto
    {
        public HomeViewModel(HomeModelDto dto)
        {
            dto.MapTo(this);
        }
    }
}
