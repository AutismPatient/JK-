using Abp.Domain.Entities;
using ppl.New;
using ppl.NewsTag;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsAndTag
{
    /// <summary>
    /// 关联中间表
    /// </summary>
    [Table("NewAndTag")]
    public class NewAndTag:Entity<Guid>
    {
        public Guid NewsId { get; set; }
        public News news { get; set; }

        public Guid TagId { get; set; }
        public NewsTags Tag { get; set; }
    }
}
