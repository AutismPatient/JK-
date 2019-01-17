using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Controllers;
using ppl.NewsCategorys;
using ppl.NewsCategorys.Dto;
using ppl.Web.Models.NewsManger.Category;

namespace ppl.Web.Mvc.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_Category)]
    public class NewsCategorysController : pplControllerBase
    {
        private readonly INewsCategoryAppService _categoryAppService;
        public NewsCategorysController(INewsCategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }
        public async Task<IActionResult> Index(PageRequestBase input)
        {
            var category = _categoryAppService.GetAll();
            var seachlist =ObjectMapper.Map<List<NewsCategoryDto>>(category.Where(x => x.CategoryName.Contains(input.SearchedName)).OrderByDescending(x => x.CreationTime).ToList());
            seachlist = seachlist.Skip(input.SkipCount).Take(input.PageSize).ToList();
            var model = new CategoryViewModel()
            {
                NewsCategories=seachlist,
                TotalCount=seachlist.Count,
                PageIndex=input.PageIndex,
                HasNextPage=input.NextPage,
                PageSize=input.PageSize,
                HasPreviousPage=input.HasPreviousPage,
                TotalPageCount=input.PageCount,
            };
            return View(model);
        }
        
        public async Task<ActionResult> GetCategoryEdit(Guid Id)
        {
            var category = await _categoryAppService.GetCategoryEdit(new EntityDto<Guid>(Id));
            var model = new EditCategoryViewModel(category);
            return View("_EditCategoryModal", model);
        }
        
    }
}