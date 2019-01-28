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
    public class NewsListViewModel<T,TCategory,Ttag>: ViewModelBase<T> where T:class where TCategory:class where Ttag:class 
    {
        public NewsListViewModel(PageReturnDto<T> pageReturnDto,IReadOnlyList<TCategory> categoryDto,IReadOnlyList<Ttag> tagDto,TCategory single):base(pageReturnDto)
        {
            NewsList = pageReturnDto.EntityItems;
            tags = tagDto;
            newsCategoryDtos = categoryDto;
            newsCategories = single;
        }
        public IReadOnlyList<T> NewsList { get; set; }
        public IReadOnlyList<Ttag> tags { get; set; }
        public TCategory newsCategories { get; set; }
        
        public IReadOnlyList<TCategory> newsCategoryDtos { get; set; }
    }
}
