using Abp.AutoMapper;
using ppl.Languages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Languages
{
    [AutoMapFrom(typeof(LanguagesOutput))]
    public class GetLanguageViewModel: LanguagesOutput
    {
        public GetLanguageViewModel(LanguagesOutput output)
        {
            output.MapTo(this);
        }
    }
}
