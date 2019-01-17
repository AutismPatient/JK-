using Abp.Application.Services.Dto;
using ppl.New;
using ppl.NewsAndTag;
using ppl.NewsCategorys;
using ppl.NewsCategorys.Dto;
using ppl.NewsTag.Dto;
using ppl.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsManger.Dto
{
    public class GetNewsEdit: FullAuditedEntityDto<Guid>
    {
        public virtual NewsDto News { get; set; }
        public virtual NewsCategoryDto newsCategory { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public virtual List<TagDto> NewsTags { get; set; }
        public virtual List<NewsCategoryDto> NewsCategories { get; set; }
        public virtual List<TagDto> TagDtos { get; set; }
    }
}
