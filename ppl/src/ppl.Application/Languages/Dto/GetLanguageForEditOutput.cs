using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class GetLanguageForEditOutput
    {
        /// <summary>
        /// Gets or sets the Language
        /// </summary>
        public LanguageEditDto Language { get; set; }

        /// <summary>
        /// Gets or sets the LanguageNames
        /// </summary>
        public List<ComboboxItemDto> LanguageNames { get; set; }

        /// <summary>
        /// Gets or sets the Flags
        /// </summary>
        public List<ComboboxItemDto> Flags { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguageForEditOutput"/> class.
        /// </summary>
        public GetLanguageForEditOutput()
        {
            LanguageNames = new List<ComboboxItemDto>();
            Flags = new List<ComboboxItemDto>();
        }
    }
}
