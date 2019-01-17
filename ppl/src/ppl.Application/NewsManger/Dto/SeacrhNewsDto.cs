using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsManger.Dto
{
    public class SeacrhNewsDto : IPagedResultRequest
    {
        [StringLength(40, MinimumLength = 1)]
        public string SearchedName { get; set; }
        public int SkipCount { get ; set ; }
        public int MaxResultCount { get ; set ; }
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
