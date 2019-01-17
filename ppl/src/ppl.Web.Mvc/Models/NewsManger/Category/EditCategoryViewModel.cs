using Abp.AutoMapper;
using ppl.NewsCategorys.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.Category
{
    [AutoMapFrom(typeof(CreateOrUpdateCategoryDto))]
    public class EditCategoryViewModel: CreateOrUpdateCategoryDto
    {
        public EditCategoryViewModel(CreateOrUpdateCategoryDto edit)
        {
            edit.MapTo(this);
        }
    }
}
