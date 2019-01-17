using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class LanguageEditDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public virtual int? Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [Required]
        [StringLength(10)]
        public virtual string Name { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Icon
        /// </summary>
        [StringLength(128)]
        public virtual string Icon { get; set; }

        /// <summary>
        /// Mapped from Language.IsDisabled with using manual mapping in CustomDtoMapper.cs
        /// </summary>
        public bool IsDisabled { get; set; }
    }
}
