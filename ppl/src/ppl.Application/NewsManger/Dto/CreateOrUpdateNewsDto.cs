using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using ppl.New;
using ppl.NewsAndTag;
using ppl.NewsCategorys;
using ppl.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ppl.JklConsts;

namespace ppl.NewsManger.Dto
{
    
    public class CreateOrUpdateNewsDto : FullAuditedEntityDto<Guid>
    {
        public CreateOrUpdateNewsDto()
        {
            
        }
        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public virtual string Abstract { get; set; }
        /// <summary>
        /// 封面图片地址
        /// </summary>
        public virtual string CoverUrl { get; set; }
        /// <summary>
        /// 阅读时间
        /// </summary>
        public virtual int ReadTime { get; set; }
        /// <summary>
        /// 类型（列表）
        /// </summary>
        public virtual ListType ListType { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public virtual string Content { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public virtual Recommend Recommend { get; set; }
        /// <summary>
        /// 审核
        /// </summary>
        public virtual Audit Audit { get; set; } = Audit.No;
        /// <summary>
        /// 状态
        /// </summary>
        public virtual Status Status { get; set; } = Status.待审核;
        /// <summary>
        /// 用户浏览量
        /// </summary>
        public virtual int PageView { get; set; } = 0;
        /// <summary>
        /// 作者ID
        /// </summary>
        public virtual long UserId { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public virtual UserDto Author { get; set; }
        public virtual Guid CategoryId { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public virtual List<NewAndTag> NewsTags { get; set; }
        public virtual string TagListName { get; set; }
        public virtual List<NewsCategory> NewsCategories { get; set; }
    }
}
