using ppl.NewsTag;
using ppl.NewsTag.Dto;
using ppl.Web.Models.Common;
using ppl.Web.Models.NewsManger.NewsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.Tag
{
    public class TagViewModel: PageListViewModelBase
    {
        public virtual List<NewsTags> NewsTags { get; set; }
    }
}
