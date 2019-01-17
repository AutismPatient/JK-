using ppl.FeedBack.Dto;
using ppl.Web.Models.Common;
using ppl.Web.Models.NewsManger.NewsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.FeedBack
{
    public class FeedBackViewModel: PageListViewModelBase
    {
        public virtual IReadOnlyList<FeedBackDto> FeedBacks { get; set; }
    }
}
