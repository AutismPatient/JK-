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
        public async Task<IActionResult> Index(SeacrhCategorys input)
        {
            input.PageIndex= input.PageIndex == null || input.PageIndex<1 ? 1 : input.PageIndex;
            input.PageSize = input.PageSize == null ? 15 : input.PageSize;
            input.SearchedName = input.SearchedName == null ? "" : input.SearchedName;
            var category = await _categoryAppService.GetAll();
            var seachlist = category.Where(x => x.CategoryName.Contains(input.SearchedName)).OrderByDescending(x => x.CreationTime).ToList();
            var Count = seachlist.Count();
            var PageCount = Count / input.PageSize.Value;
            var dataTol= Count % input.PageSize.Value != 0;
            PageCount= dataTol == true || PageCount==0 ? PageCount + 1 : PageCount;
            if (Count != 0)
            {
                if (input.PageIndex > PageCount)
                {
                    input.PageIndex = PageCount;
                }
            }
            var NextPage = PageCount - input.PageIndex > 0 ? true:false ;
            var HasPreviousPage = input.PageIndex != 1 ? true : false;
            seachlist = seachlist.Skip((input.PageIndex.Value - 1) * input.PageSize.Value).Take(input.PageSize.Value).ToList();
            var model = new CategoryViewModel()
            {
                NewsCategories=seachlist,
                TotalCount=Count,
                PageIndex=input.PageIndex.Value,
                HasNextPage=NextPage,
                PageSize=input.PageSize.Value,
                HasPreviousPage=HasPreviousPage,
                TotalPageCount=PageCount,
                
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