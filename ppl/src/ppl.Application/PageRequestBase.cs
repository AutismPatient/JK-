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
    public class PageRequestBase 
    {
        int pageindex;
        int pagecount;
        int pagesize = 10;
        public int Count;
        int skip;
        bool nextpage;
        bool hasPreviousPage;
        string name="";
        public PageRequestBase()
        {
            
        }
        /// <summary>
        /// 搜索词
        /// </summary>
        public string SearchedName { get { return name ; } set { if (SearchedName == null) value = name; } }
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
        /// 当前页数
        /// </summary>
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
            get { return nextpage; }
            set
            {
                if (PageCount - PageIndex > 0)
                    nextpage = true;
                else
                    nextpage = false;
            }
        }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage
        {
            get { return hasPreviousPage; }
            set
            {
                if (PageIndex >= 1)
                    hasPreviousPage = true;
                else
                    hasPreviousPage = false;
            }
        }
    }
}
