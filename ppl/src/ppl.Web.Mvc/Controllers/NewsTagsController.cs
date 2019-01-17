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
        public async Task<IActionResult> Index(SeacrhTagDto input)
        {
            input.PageIndex = input.PageIndex == null || input.PageIndex < 1 ? 1 : input.PageIndex;
            input.PageSize = input.PageSize == null ? 15 : input.PageSize;
            input.SearchedName = input.SearchedName == null ? "" : input.SearchedName;
            var tag = await _tagAppService.GetAll();
            var seachlist = tag.Where(x => x.TagName.Contains(input.SearchedName)).OrderByDescending(x => x.CreationTime).ToList();
            var Count = seachlist.Count();
            var PageCount = Count / input.PageSize.Value;
            var dataTol = Count % input.PageSize.Value != 0;
            PageCount = dataTol == true || PageCount==0 ? PageCount + 1 : PageCount;
            if (Count != 0)
            {
                if (input.PageIndex > PageCount)
                {
                    input.PageIndex = PageCount;
                }
            }
            var NextPage = PageCount - input.PageIndex > 0 ? true : false;
            var HasPreviousPage = input.PageIndex != 1 ? true : false;
            seachlist = seachlist.Skip((input.PageIndex.Value - 1) * input.PageSize.Value).Take(input.PageSize.Value).ToList();
            var model = new TagViewModel()
            {
                NewsTags = seachlist,
                TotalCount = Count,
                PageIndex = input.PageIndex.Value,
                HasNextPage = NextPage,
                PageSize = input.PageSize.Value,
                HasPreviousPage = HasPreviousPage,
                TotalPageCount = PageCount,
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