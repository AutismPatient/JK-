using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.FeedBack
{
    public class FeedBacks : Entity, IDeletionAudited, IAudited
    {

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Email { get; set; }

        [Required]
        [MaxLength(256)]
        public string Main { get; set; }
        public long? DeleterUserId { get ; set ; }
        public DateTime? DeletionTime { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public long? CreatorUserId { get ; set ; }
        public DateTime CreationTime { get ; set ; }
        public long? LastModifierUserId { get ; set ; }
        public DateTime? LastModificationTime { get ; set ; }
    }
}
