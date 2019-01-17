using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ppl.Controllers;

namespace ppl.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : pplControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
