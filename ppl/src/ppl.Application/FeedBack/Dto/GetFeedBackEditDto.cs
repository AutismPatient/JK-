using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.FeedBack.Dto
{
    public class GetFeedBackEditDto: FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Main { get; set; }
    }
}
