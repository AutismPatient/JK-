using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ppl.New;
using System.ComponentModel.DataAnnotations.Schema;
using ppl.NewsAndTag;

namespace ppl.NewsTag
{
    /// <summary>
    /// 新闻标签
    /// </summary>
    public class NewsTags:Entity<Guid>, IDeletionAudited, IAudited
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        [StringLength(JklConsts.MaxTagsLength)]
        public virtual string TagName { get; set; }
        public virtual ICollection<NewAndTag> NewTags { get; set; }
        public long? DeleterUserId { get ; set ; }
        public DateTime? DeletionTime { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public long? CreatorUserId { get ; set; }
        public DateTime CreationTime { get ; set ; }
        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get ; set ; }
    }
}
