using Abp.Application.Services.Dto;
using ppl.NewsManger.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys.Dto
{
    public class CreateOrUpdateCategoryDto:FullAuditedEntityDto<Guid>
    {
        public virtual string CategoryName { get; set; }
    }
}
