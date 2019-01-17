using Abp.AutoMapper;
using ppl.NewsManger.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.NewsList
{
    [AutoMapFrom(typeof(GetNewsEdit))]
    public class EditNewsViewModel: GetNewsEdit
    {
        public EditNewsViewModel(GetNewsEdit edit)
        {
            edit.MapTo(this);
        }
    }
}
