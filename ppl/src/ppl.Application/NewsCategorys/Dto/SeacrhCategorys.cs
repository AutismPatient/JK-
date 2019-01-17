using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsCategorys.Dto
{
    public class SeacrhCategorys : IPagedResultRequest
    {
        [StringLength(16, MinimumLength = 1)]
        public string SearchedName { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
        public bool IsDelete { get; set; }
        /// <summary>
        /// 当前页数
        /// </summary>
        [Range(1, int.MaxValue)]
        public int? PageIndex { get; set; }

        /// <inheritdoc />
        [Range(0, int.MaxValue)]
        public int? PageSize { get; set; } //0：无限制。
    }
}
