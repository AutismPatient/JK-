using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class LanguagesDto: FullAuditedEntityDto
    {
        /// <summary>
        /// Gets or sets the TenantId
        /// </summary>
        public virtual Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the DisplayName
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Icon
        /// </summary>
        public virtual string Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsDisabled
        /// </summary>
        public bool IsDisabled { get; set; }
    }
}
