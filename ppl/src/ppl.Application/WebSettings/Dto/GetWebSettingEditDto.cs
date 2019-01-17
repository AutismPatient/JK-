using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.WebSettings.Dto
{
    [AutoMapFrom(typeof(WebSetting))]
    public class GetWebSettingEditDto:EntityDto<Guid>
    {
        /// <summary>
        /// 首页标题栏
        /// </summary>
        public string HomeUrlTitle { get; set; }
        /// <summary>
        /// 关键词
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 图标设置
        /// </summary>
        public string IconUrl { get; set; }
    }
}
