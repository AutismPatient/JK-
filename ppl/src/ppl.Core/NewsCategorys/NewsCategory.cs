using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys
{
    /// <summary>
    /// 文章类别
    /// </summary>
    public class NewsCategory : Entity<Guid>, IDeletionAudited, IAudited
    {
        [StringLength(JklConsts.MaxCategoryLength)]
        public virtual string CategoryName { get; set; }
        public long? DeleterUserId { get ; set ; }
        public DateTime? DeletionTime { get ; set ; }
        public bool IsDeleted { get ; set; }
        public long? CreatorUserId { get ; set ; }
        public DateTime CreationTime { get; set ; }
        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get ; set ; }
    }
}
