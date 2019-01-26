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
    /// 分页输入Dto
    /// </summary>
    public class PageRequestInput
    {
        string name;
        int pageindex;
        int pagesize;
        public PageRequestInput()
        {

        }
        /// <summary>
        /// 搜索词
        /// </summary>
        public string SearchedName
        {
            get
            {
                return name ?? "";
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex
        {
            get
            {
                return pageindex <= 0 ? 1 : pageindex;
            }
            set
            {
                pageindex = value;
            }
        }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize
        {
            get
            {
                return pagesize <= 0 ? 10 : pagesize;
            }
            set
            {
                pagesize = value;
            }
        }
    }
}
