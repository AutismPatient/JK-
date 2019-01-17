﻿using ppl.NewsCategorys;
using ppl.Web.Models.Common;
using ppl.Web.Models.NewsManger.NewsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.Category
{
    public class CategoryViewModel: PageListViewModelBase
    {
        public virtual List<NewsCategory> NewsCategories { get; set; } 
    }
}
