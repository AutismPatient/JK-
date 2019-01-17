using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Controllers;
using ppl.Web.Models.WebSettings;
using ppl.WebSettings;
using ppl.WebSettings.Dto;

namespace ppl.Web.Mvc.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_WebParameter)]
    public class WebSettingController: pplControllerBase
    {
        private readonly IWebSettingAppService _appService;
        public WebSettingController(IWebSettingAppService appService)
        {
            _appService = appService;
        }
        public async Task<IActionResult> EditForWeb(Guid? id)
        {
            CreateOrUpdateViewModel model=new CreateOrUpdateViewModel(new GetWebSettingEditDto());
            if (!id.HasValue)
            {
                id = _appService.GuidAsync();
                model = new CreateOrUpdateViewModel(await _appService.GetSingleEdit(id.Value));
            }
            return View(model);
        }
    }
}