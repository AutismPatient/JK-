using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ppl.Controllers;
using ppl.Home;
using ppl.Web.Models.Home;
using System.Threading.Tasks;

namespace ppl.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : pplControllerBase
    {
        public readonly IHomeAppService service;
        public HomeController(IHomeAppService _service)
        {
            service = _service;
        }
        public async Task<ActionResult> Index()
        {
            var model = new HomeViewModel(await service.HomeCountAsync());
            return View(model);
        }
	}
}
