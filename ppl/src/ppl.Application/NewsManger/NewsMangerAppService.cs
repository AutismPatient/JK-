using Abp.Domain.Repositories;
using ppl.New;
using System;
using ppl.NewsCategorys;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ppl.NewsTag;
using Abp.Application.Services.Dto;
using ppl.NewsManger.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Abp.Application.Services;
using Abp.UI;
using ppl.NewsAndTag;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ppl.Authorization.Users;
using ppl.Users.Dto;
using Abp.ObjectMapping;
using ppl.NewsCategorys.Dto;
using ppl.NewsTag.Dto;
using static ppl.JklConsts;
using Abp.Authorization;
using ppl.Authorization;

namespace ppl.NewsManger
{
    [AbpAuthorize(PermissionNames.Pages_NewsManger)]
    /// <summary>
    /// 资料管理服务
    /// </summary>
    public class NewsMangerAppService : AsyncCrudAppService<News, NewsDto, Guid, PagedResultRequestDto, CreateOrUpdateNewsDto, NewsDto>, INewsMangerAppService
    {
        /// <summary>
        /// 注入仓储
        /// </summary>
        private readonly IRepository<News, Guid> _newsRepository;
        private readonly IRepository<NewsCategory, Guid> _categoryRepository;
        private readonly IRepository<NewsTags, Guid> _tagRepository;
        private readonly IRepository<NewAndTag, Guid> _andrepository;
        private readonly UserManager _userManager;
        private readonly IObjectMapper _objectMapper;
        private readonly INewsCategoryAppService _categoryAppService;
        private readonly INewsTagAppService _newsTagAppService;


        public NewsMangerAppService(IRepository<News, Guid> newsRepository,
            IRepository<NewsCategory, Guid> categoryRepository,
            IRepository<NewsTags, Guid> tagRepository,
            IRepository<NewAndTag, Guid> repository,
            UserManager userManager,
            IObjectMapper objectMapper,
            INewsCategoryAppService categoryAppService,
            INewsTagAppService newsTagAppService
            ) : base(newsRepository)
        {
            _andrepository = repository;
            _newsRepository = newsRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            _userManager = userManager;
            _objectMapper = objectMapper;
            _categoryAppService = categoryAppService;
            _newsTagAppService = newsTagAppService;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="createOrUpdateNewsDto"></param>
        /// <returns></returns>
        [AbpAuthorize(PermissionNames.Pages_CreateData)]
        public async Task CreateSingle(CreateOrUpdateNewsDto createOrUpdateNewsDto, string taglist, string url)
        {
            try
            {
                var Exits = await this._newsRepository.FirstOrDefaultAsync(x => x.Title == createOrUpdateNewsDto.Title);
                if (Exits != null)
                {
                    throw new UserFriendlyException(L("标题请勿重复！"));
                }
                createOrUpdateNewsDto.UserId = AbpSession.UserId.Value;
                createOrUpdateNewsDto.CoverUrl = url;
                var news = this._objectMapper.Map<News>(createOrUpdateNewsDto);
                await _newsRepository.InsertAsync(news);
                await CreateTagAndNews(taglist, news.Id);
            }
            catch(UserFriendlyException)
            {
                throw new UserFriendlyException("未知错误！");
            }
            
        }
        public async Task DeleteAsync(News news)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_DeleteData))
                throw new UserFriendlyException("您没有权限！");
            await _newsRepository.DeleteAsync(news);
        }
        public async Task UpdateAsync(News news)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_UpdateData))
                throw new UserFriendlyException("您没有权限！");
            await _newsRepository.UpdateAsync(news);
        }
        public async Task UpdateSingle(CreateOrUpdateNewsDto input, string taglist, string url)
        {
            var newsFir = await this._newsRepository.GetAsync(input.Id);
            if (newsFir.Equals(null))
            {
                throw new UserFriendlyException("发生意外错误！");
            }
            input.Audit = newsFir.Audit;
            input.Status = newsFir.Status;
            input.CoverUrl = url;
            var news = _objectMapper.Map(input, newsFir);
            await this.UpdateAsync(news);
            await CreateTagAndNews(taglist, newsFir.Id);
        }
        /// <summary>
        /// 遍历加标签
        /// </summary>
        /// <param name="TagListName"></param>
        /// <param name="NewsId"></param>
        /// <returns></returns>
        public async Task CreateTagAndNews(string TagListName, Guid NewsId)
        {
            if (TagListName.Length == 0)
            {
                throw new UserFriendlyException(L("至少选择一个标签！"));
            }
            string[] str = TagListName.Split(',');
            if(str.Count()>10)
                throw new UserFriendlyException(L("最多可以关联10个标签"));
            var Nyton = _andrepository.GetAll().Where(x => x.NewsId == NewsId).ToList();
            if (Nyton.Any())
            {
                foreach (var s in Nyton)
                {
                    var single = await _tagRepository.FirstOrDefaultAsync(x => x.Id == s.TagId);
                    var Tag = await this._tagRepository.FirstOrDefaultAsync(x => x.TagName == single.TagName);
                    var tagandnews = await _andrepository.FirstOrDefaultAsync(x => x.TagId == Tag.Id && x.NewsId == s.NewsId);
                    if (!str.Contains(single.TagName))
                    {
                        if (tagandnews != null)
                        {
                            await _andrepository.DeleteAsync(tagandnews);
                        }
                    }
                    foreach (var p in str)
                    {
                        if (!p.Equals(single.TagName))
                        {
                            var Tags = await this._tagRepository.FirstOrDefaultAsync(x => x.TagName == p);
                            var tagEntity = new NewsAndTagsDto()
                            {
                                TagId = Tags.Id,
                                NewsId = NewsId
                            };
                            var pler = await _andrepository.FirstOrDefaultAsync(x => x.NewsId == NewsId && x.TagId == Tags.Id);
                            if (pler == null)
                            {
                                var TagAndNews = _objectMapper.Map<NewAndTag>(tagEntity);
                                await _andrepository.InsertAsync(TagAndNews);
                                await CurrentUnitOfWork.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var liststr in str)
                {
                    var Tag = await this._tagRepository.FirstOrDefaultAsync(x => x.TagName == liststr);
                    var tagEntity = new NewsAndTagsDto()
                    {
                        TagId = Tag.Id,
                        NewsId = NewsId
                    };
                    var TagAndNews = _objectMapper.Map<NewAndTag>(tagEntity);
                    await _andrepository.InsertAsync(TagAndNews);
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task DeleteSingle(Guid Id)
        {
            var news = await this._newsRepository.GetAsync(Id);
            await this.DeleteAsync(news);
            await CurrentUnitOfWork.SaveChangesAsync();
        }
        public async Task<GetNewsEdit> GetNewsEdit(Abp.Application.Services.Dto.EntityDto<Guid> entity)
        {
            var Getcategory =await _categoryAppService.GetAll();
            var GetTags = _tagRepository.GetAll();
            var news = await _newsRepository.GetAsync(entity.Id);
            var category = Getcategory.FirstOrDefault(x => x.Id == news.CategoryId);
            var listcategory = _objectMapper.Map<List<NewsCategoryDto>>(Getcategory.ToList());
            var tags = _andrepository.GetAll().Where(x => x.NewsId == news.Id);
            var tagids = tags.Select(x => x.TagId).ToList();

            var selectTag = _objectMapper.Map<List<TagDto>>(GetTags.Where(x => tagids.Contains(x.Id)));
            var listtag = _objectMapper.Map<List<TagDto>>(GetTags.Where(x => !tagids.Contains(x.Id)));
            return new GetNewsEdit()
            {
                News = _objectMapper.Map<NewsDto>(news),
                newsCategory = _objectMapper.Map<NewsCategoryDto>(category),
                NewsTags = selectTag,
                NewsCategories = listcategory,
                TagDtos = listtag
            };
        }
        [AbpAllowAnonymous]
        public List<NewsDto> GetAll()
        {
            return ObjectMapper.Map<List<NewsDto>>(_newsRepository.GetAll());
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ListGuid"></param>
        /// <returns></returns>
        public async Task BatchDelete(string ListGuid)
        {
            string[] str = ListGuid.Split(',');
            foreach (var s in str)
            {
                var News = await this._newsRepository.GetAsync(new Guid(s));
                await this.DeleteAsync(News);
            }
        }
        public async Task BatchRecover(string GuidList)
        {
            string[] str = GuidList.Split(',');
            foreach (var s in str)
            {
                var News = await this._newsRepository.GetAsync(new Guid(s));
                News.IsDeleted = false;
                await this.UpdateAsync(News);
            }
        }
        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Recover(Guid id)
        {
            var News = await this._newsRepository.FirstOrDefaultAsync(x => x.Id == id);
            News.IsDeleted = false;
            await this.UpdateAsync(News);
        }
        public async Task Audital(Guid Id,Status select)
        {
            var single = await _newsRepository.FirstOrDefaultAsync(Id);
            if (single == null)
                return;
            if (select != Status.已通过审核 || select!=Status.封禁)
                single.Audit = Audit.No;
            else
                single.Audit = Audit.Yes;
            single.Status = select;
            await this.UpdateAsync(single);
            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }
}
