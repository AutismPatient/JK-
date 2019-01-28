using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Common.PageInfoModel
{
    /// <summary>
    /// 分页分部视图视图模型
    /// </summary>
    public class PageViewModel : PageListViewModelBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="pageindex">页码索引</param>
        /// <param name="pagesize">每页数</param>
        /// <param name="toalpagecount">总页数</param>
        /// <param name="haspreviouspage">是否存在上一页</param>
        /// <param name="nextpage">是否存在下一页</param>
        /// <param name="totalcount">条目总数</param>
        public PageViewModel(string controller, string aation, int pageindex, int pagesize, int totalpagecount, bool haspreviouspage, bool nextpage, int totalcount)
        {
            PageIndex = pageindex;
            PageSize = pagesize;
            TotalCount = totalcount;
            TotalPageCount = totalpagecount;
            HasNextPage = nextpage;
            HasPreviousPage = haspreviouspage;
        }
        public virtual string ActionUrl { get; set; }
        public virtual string Controller { get; set; }
    }
}
