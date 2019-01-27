using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.Common
{
    /// <summary>
    /// 视图模型基类
    /// </summary>
    /// <typeparam name="T">数据</typeparam>
    public class ViewModelBase<T>: PageListViewModelBase where T : class
    {
        public ViewModelBase(PageReturnDto<T> pageReturnDto)
        {
            this.Items = pageReturnDto.EntityItems;
            PageIndex = pageReturnDto.PageIndex;
            PageSize = pageReturnDto.PageSize;
            HasNextPage = pageReturnDto.NextPage;
            HasPreviousPage = pageReturnDto.HasPreviousPage;
            TotalCount = pageReturnDto.Count;
            TotalPageCount = pageReturnDto.PageCount;
        }
        public ViewModelBase(IReadOnlyList<T> List):base()
        {

        }
        public virtual IReadOnlyList<T> Items { get; set; }

    }
}
