using Abp.AutoMapper;
using ppl.Languages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class GetLanguagesEdit: GetLanguageForEditOutput
    {
        public GetLanguagesEdit(GetLanguageForEditOutput dto)
        {
            dto.MapTo(this);
        }
    }
}
