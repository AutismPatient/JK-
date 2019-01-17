using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using ppl.Authorization.Users;
using ppl.NewsAndTag;
using ppl.NewsTag;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.New
{
    /// <summary>
    /// 新闻
    /// </summary>
    public class News: Entity<Guid>,IAudited, IDeletionAudited
    {

        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        [MaxLength(JklConsts.MaxTitleLength)]
        public virtual string Title { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [Required]
        [MaxLength(JklConsts.MaxTitleLength)]
        public virtual string Abstract { get; set; }
        /// <summary>
        /// 封面图片地址
        /// </summary>
        public virtual string CoverUrl { get; set; }
        /// <summary>
        /// 阅读时间
        /// </summary>
        [Required]
        public virtual int ReadTime { get; set; }
        /// <summary>
        /// 类型（列表）
        /// </summary>
        [Required]
        public virtual JklConsts.ListType ListType { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        [Required]
        public virtual string Content { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        [Required]
        public virtual JklConsts.Recommend Recommend { get; set; }
        /// <summary>
        /// 审核
        /// </summary>
        [Required]
        public virtual JklConsts.Audit Audit { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required]
        public virtual JklConsts.Status Status { get; set; }
        /// <summary>
        /// 用户浏览量
        /// </summary>
        [Required]
        public virtual int PageView { get; set; }
        /// <summary>
        /// 作者ID
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public virtual User Author { get; set; }
        public virtual Guid CategoryId { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        [ForeignKey(nameof(CategoryId))]
        public virtual NewsCategorys.NewsCategory NewsCategories { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public virtual ICollection<NewAndTag> NewsTags { get; set; }

        public long? CreatorUserId { get ; set ; }
        public DateTime CreationTime { get ; set ; }
        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get ; set; }
        public long? DeleterUserId { get ; set; }
        public DateTime? DeletionTime { get; set ; }
        public bool IsDeleted { get ; set ; }

    }
    
}
