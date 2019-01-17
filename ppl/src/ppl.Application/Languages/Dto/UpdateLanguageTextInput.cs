using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class UpdateLanguageTextInput
    {
        /// <summary>
        /// Gets or sets the LanguageName
        /// </summary>
        [Required]
        [StringLength(10)]
        public string LanguageName { get; set; }

        /// <summary>
        /// Gets or sets the SourceName
        /// </summary>
        [Required]
        [StringLength(128)]
        public string SourceName { get; set; }

        /// <summary>
        /// Gets or sets the Key
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(1024*64*64)]
        public string Value { get; set; }
    }
}
