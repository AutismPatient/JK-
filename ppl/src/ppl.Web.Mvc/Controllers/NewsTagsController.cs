using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Controllers;
using ppl.NewsTag;
using ppl.NewsTag.Dto;
using ppl.Web.Models.NewsManger.Tag;

namespace ppl.Web.Mvc.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_Tags)]
    public class NewsTagsController : pplControllerBase
    {
        private readonly INewsTagAppService _tagAppService;
        public NewsTagsController(INewsTagAppService tagAppService)
        {
            _tagAppService = tagAppService;
        }
        public async Task<IActionResult> Index(PageRequestBase input)
        {
            var tag = await _tagAppService.GetAll();
            input.Count = tag.Count;
            var input1 = new PageRequestBase { };
            var seachlist = tag.Where(x => x.TagName.Contains(input.SearchedName)).OrderByDescending(x => x.CreationTime).ToList();
            seachlist = seachlist.Skip(input.SkipCount).Take(input.PageSize).ToList();
            var model = new TagViewModel()
            {
                NewsTags = seachlist,
                TotalCount = tag.Count,
                PageIndex = input.PageIndex,
                HasNextPage =input.NextPage,
                PageSize = input.PageSize,
                HasPreviousPage =input.HasPreviousPage,
                TotalPageCount =input.PageCount,
            };
            return View(model);
        }
        public async Task<ActionResult> GetTagsEdit(Guid Id)
        {
            var tag = await _tagAppService.GetTagEdit(new EntityDto<Guid>(Id));
            var model = new EditTagsViewModel(tag);
            return View("_EditTagsModal", model);
        }
    }
}