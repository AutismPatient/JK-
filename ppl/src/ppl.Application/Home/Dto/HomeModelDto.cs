using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Home.Dto
{
    public class HomeModelDto
    {
        public virtual int NewsCount { get; set; }
        public virtual int TagsCount { get; set; }
        public virtual int CategoryCount { get; set; }
        public virtual int FeedBackCount { get; set; }
    }
}
