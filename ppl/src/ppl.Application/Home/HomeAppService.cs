using Abp.Domain.Repositories;
using ppl.FeedBack;
using ppl.Home.Dto;
using ppl.New;
using ppl.NewsCategorys;
using ppl.NewsTag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Home
{
    public class HomeAppService:pplAppServiceBase,IHomeAppService
    {
        private readonly IRepository<News, Guid> _news;
        private readonly IRepository<NewsTags, Guid> _tag;
        private readonly IRepository<NewsCategory, Guid> _category;
        private readonly IRepository<FeedBacks> _feedback;
        public HomeAppService(IRepository<News, Guid> news, IRepository<NewsTags, Guid> tag, IRepository<NewsCategory, Guid> category, IRepository<FeedBacks> feedback)
        {
            _news = news;
            _tag = tag;
            _category = category;
            _feedback = feedback;
        }
        public async Task<HomeModelDto> HomeCountAsync()
        {
            return new HomeModelDto()
            {
                NewsCount = await _news.CountAsync(),
                TagsCount=await _tag.CountAsync(),
                CategoryCount=await _category.CountAsync(),
                FeedBackCount=await _feedback.CountAsync()
            };
        }
    }
}
