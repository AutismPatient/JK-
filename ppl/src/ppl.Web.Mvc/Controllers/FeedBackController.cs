using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Controllers;
using ppl.FeedBack;
using ppl.Web.Models.FeedBack;

namespace ppl.Web.Mvc.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_FeedBack)]
    public class FeedBackController : pplControllerBase
    {
        public readonly IFeedBackAppService _service;
        public FeedBackController(IFeedBackAppService service)
        {
            _service = service;
        }
        public IActionResult Index(PageRequestBase input)
        {
            input.SearchedName = input.SearchedName == null ? "" : input.SearchedName;
            var ListModel = _service.GetAll();
            var seachlist = ListModel.Result.Where(x => x.Name.Contains(input.SearchedName) && x.IsDeleted==false).OrderByDescending(x => x.CreationTime).ToList();
            var Count = seachlist.Count();
            var PageCount = Count / input.PageSize;
            var dataTol = Count % input.PageSize != 0;
            PageCount = dataTol == true || PageCount == 0 ? PageCount + 1 : PageCount;
            if (Count != 0)
            {
                if (input.PageIndex > PageCount)
                {
                    input.PageIndex = PageCount;
                }
            }
            var NextPage = PageCount - input.PageIndex > 0 ? true : false;
            var HasPreviousPage = input.PageIndex != 1 ? true : false;
            seachlist = seachlist.Skip((input.PageIndex - 1) * input.PageSize).Take(input.PageSize).ToList();
            var model = new FeedBackViewModel()
            {
                FeedBacks = seachlist,
                TotalCount = Count,
                PageIndex = input.PageIndex,
                HasNextPage = NextPage,
                PageSize = input.PageSize,
                HasPreviousPage = HasPreviousPage,
                TotalPageCount = PageCount,
            };
            return View(model);
        }
        public PartialViewResult GetEdit(int Id)
        {
            var model = _service.GetEditModel(Id).Result;
            return PartialView("_Edit", new CreateOrUpdateViewModel(model));
        }
    }
}