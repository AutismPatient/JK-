using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ppl.FeedBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl
{
    /// <summary>
    /// Select控件 （扩展方法）
    /// </summary>
    public static class ComboboxItemHelper
    {
        public static SelectListItem ToSelectItem(this ComboboxItemDto combobox)
        {
            return new SelectListItem
            {
                Text = combobox.DisplayText,
                Selected = combobox.IsSelected,
                Value = combobox.Value
            };
        }
    }
}
