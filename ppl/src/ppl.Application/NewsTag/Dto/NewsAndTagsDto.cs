using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ppl.New;
using ppl.NewsAndTag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsManger.Dto
{
    [AutoMapTo(typeof(NewAndTag))]
    public class NewsAndTagsDto:EntityDto<Guid>
    {
        public Guid NewsId { get; set; }

        public Guid TagId { get; set; }
    }
}
