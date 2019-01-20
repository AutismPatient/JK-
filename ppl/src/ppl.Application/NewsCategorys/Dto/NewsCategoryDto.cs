using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys.Dto
{
    [AutoMapTo(typeof(NewsCategory))]
    public class NewsCategoryDto: FullAuditedEntityDto<Guid>
    {
        
        public string CategoryName { get; set; }
        public NewsCategoryDto()
        {
            CreationTime = DateTime.Now;
        }
    }
}
