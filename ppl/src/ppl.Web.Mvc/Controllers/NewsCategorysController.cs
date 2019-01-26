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
        public async Task<IActionResult> Index(PageRequestInput input)
        {
            var category =await _categoryAppService.GetAll();
            var seachlist =ObjectMapper.Map<IReadOnlyList<NewsCategoryDto>>(category.Where(x => x.CategoryName.Contains(input.SearchedName)).OrderByDescending(x => x.CreationTime));
            var dto = new PageReturnDto<NewsCategoryDto>(seachlist, input.PageIndex, input.PageSize);
            return View();
        }
        
        public async Task<ActionResult> GetCategoryEdit(Guid Id)
        {
            var category = await _categoryAppService.GetCategoryEdit(new EntityDto<Guid>(Id));
            var model = new EditCategoryViewModel(category);
            return View("_EditCategoryModal", model);
        }
        
    }
}