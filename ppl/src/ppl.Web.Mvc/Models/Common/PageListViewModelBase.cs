using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Common
{
    /// <summary>
    /// 分页所需视图模型基类
    /// </summary>
    public class PageListViewModelBase
    {
        /// <summary>
        /// 页码索引
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页显示数量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPageCount { get; set; }

        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }
    }
}
