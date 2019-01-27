using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl
{
    /// <summary>
    /// 分页返回结果基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageReturnDto<T> where T:class
    {
        public bool HasPreviousPage { get; set; }
        public bool NextPage { get; set; }
        public int PageCount { get; set; }
        public int Count { get; set; }
        public int SkipCount { get; set; }
        public IReadOnlyList<T> EntityItems { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public PageReturnDto(IReadOnlyList<T> items):base()
        {

        }
        public PageReturnDto(IReadOnlyList<T> items,int pageindex=1,int pagesize=10):base()
        {
            Count = items.Count();
            PageCount = (int)Math.Ceiling(items.Count / (double)pagesize);
            PageIndex= pageindex = pageindex > PageCount ? PageCount : pageindex;
            SkipCount = (pageindex - 1) * pagesize;
            HasPreviousPage = pageindex > 1 ? true : false;
            NextPage = PageCount > pageindex ? true : false;
            EntityItems = items.Skip(SkipCount).Take(pagesize).ToList();
        }
        
    }
}
