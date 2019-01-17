using ppl.New;
using ppl.NewsCategorys.Dto;
using ppl.NewsManger.Dto;
using ppl.NewsTag.Dto;
using ppl.Web.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ppl.Web.Models.NewsManger.NewsList
{
    public class NewsListViewModel: PageListViewModelBase
    {
        public List<NewsDto> NewsList { get; set; }
        public List<TagDto> tags { get; set; }
        public NewsCategoryDto newsCategories { get; set; }
        
        public List<NewsCategoryDto> newsCategoryDtos { get; set; }
    }
}
