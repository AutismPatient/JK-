using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsTag.Dto
{
    [AutoMapTo(typeof(NewsTags))]
    public class TagDto:EntityDto<Guid>
    {
        public TagDto()
        {
            this.CreationTime = DateTime.Now;
        }
        public virtual string TagName { get; set; }
        public virtual DateTime CreationTime { get; set; }
    }
}
