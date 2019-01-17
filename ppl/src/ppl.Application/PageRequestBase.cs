using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl
{
    /// <summary>
    /// 分页基类
    /// </summary>
    public class PageRequestBase : IPagedResultRequest
    {
        int pageindex;
        int pagecount;
        int pagesize = 10;
        int Count;
        int skip;
        public PageRequestBase()
        {

        }
        /// <summary>
        /// 搜索词
        /// </summary>
        [StringLength(16, MinimumLength = 1)]
        public string SearchedName { get; set; }
        /// <summary>
        /// 跳列数
        /// </summary>
        public int SkipCount
        {
            get { return skip; }
            set {
                skip =(PageIndex - 1) * PageSize;
            }
        }
        /// <summary>
        /// 最大返回值
        /// </summary>
        public int MaxResultCount { get=> Count; set { if(Count>0) value = Count; } }
        /// <summary>
        /// 当前页数
        /// </summary>
        [Range(1, int.MaxValue)]
        public int PageIndex
        {
            get { return pageindex; }
            set
            {
                if(Count>0)
                {
                    if (value < 0)
                        pageindex = 1;
                    if (value > PageCount)
                        pageindex = PageIndex;
                }
            }
        }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        [Range(5, int.MaxValue)]
        public int PageSize
        {
            get { return pagesize; }
            set
            {
                if (value < pagesize)
                    value = pagesize;
            }
        }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get { return pagecount; }
            set
            {
                if (Count > 0)
                {
                    double count = Count / PageSize;
                    pagecount = (int)Math.Ceiling(count);
                }
            }
        }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool NextPage
        {
            get { return NextPage; }
            set
            {
                if (PageCount - PageIndex > 0)
                    value = true;
                else
                    value = false;
            }
        }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage
        {
            get { return HasPreviousPage; }
            set
            {
                if (PageIndex >= 1)
                    value = true;
                else
                    value = false;
            }
        }
    }
}
