using Abp.AutoMapper;
using ppl.WebSettings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.WebSettings
{
    [AutoMapFrom(typeof(GetWebSettingEditDto))]
    public class CreateOrUpdateViewModel: GetWebSettingEditDto
    {
        public CreateOrUpdateViewModel(GetWebSettingEditDto dto)
        {
            dto.MapTo(this);
        }
    }
}
