using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Controllers;
using ppl.FeedBack;
using ppl.FeedBack.Dto;
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
        public async Task<IActionResult> Index(PageRequestInput input)
        {
            var ListModel =await _service.GetAll();
            var seachlist = ListModel.Where(x => x.Name.Contains(input.SearchedName) && x.IsDeleted==false).OrderByDescending(x => x.CreationTime).ToList();
            var dto = new PageReturnDto<FeedBackDto>(seachlist,input.PageIndex,input.PageSize);
            return View(new FeedBackViewModel() {
                FeedBacks = dto.EntityItems,
                PageIndex = dto.PageIndex,
                PageSize = dto.PageSize,
                HasNextPage = dto.NextPage,
                HasPreviousPage = dto.HasPreviousPage,
                TotalCount = dto.Count,
                TotalPageCount = dto.PageCount
            });
        }
        public PartialViewResult GetEdit(int Id)
        {
            var model = _service.GetEditModel(Id).Result;
            return PartialView("_Edit", new CreateOrUpdateViewModel(model));
        }
    }
}