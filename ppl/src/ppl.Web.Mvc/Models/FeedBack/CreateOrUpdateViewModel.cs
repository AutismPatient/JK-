using Abp.AutoMapper;
using ppl.FeedBack.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.FeedBack
{
    [AutoMapFrom(typeof(FeedBackDto))]
    public class CreateOrUpdateViewModel:FeedBackDto
    {
        public CreateOrUpdateViewModel(FeedBackDto dto)
        {
            dto.MapTo(this);
        }
    }
}
