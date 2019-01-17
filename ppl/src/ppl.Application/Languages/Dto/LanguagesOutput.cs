using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class LanguagesOutput: ListResultDto<LanguagesDto>
    {
        public virtual ListResultDto<LanguagesDto> Languages { get; set; }
        public virtual string DefaultLanguageName { get; set; }
        /// <summary>
        /// Gets or sets the LanguageNames
        /// </summary>
        public List<ComboboxItemDto> LanguageNames { get; set; }

        /// <summary>
        /// Gets or sets the Flags
        /// </summary>
        public List<ComboboxItemDto> Flags { get; set; }
        public LanguagesOutput()
        {

        }
        public LanguagesOutput(IReadOnlyList<LanguagesDto> languages,string defaultLanguageName)
            :base(languages)
        {

        }
    }
}
