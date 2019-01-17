using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using ppl.Controllers;
using ppl.Languages;
using ppl.Web.Models.Languages;

namespace ppl.Web.Mvc.Controllers
{
    public class LanguagesController : pplControllerBase
    {
        private readonly ILanguagesAppService _languagesAppService;
        public LanguagesController(ILanguagesAppService languagesAppService)
        {
            _languagesAppService = languagesAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(new GetLanguageViewModel(await _languagesAppService.GetLanguagesAsync()));
        }
        public async Task<IActionResult> GetLanguagesEdit(int Id)
        {
            return PartialView("_EditModal",new GetLanguagesEdit(await _languagesAppService.GetLanguaesEditAsync(new NullableIdDto() {Id=Id })));
        }
    }
}