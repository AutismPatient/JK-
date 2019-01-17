using Abp.AutoMapper;
using ppl.NewsTag.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.Tag
{
    [AutoMapFrom(typeof(GetTagEdit))]
    public class EditTagsViewModel: GetTagEdit
    {
        public EditTagsViewModel(GetTagEdit edit)
        {
            edit.MapTo(this);
        }
    }
}
