using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ppl.Authorization;
using ppl.Authorization.Users;
using ppl.Controllers;
using ppl.NewsCategorys;
using ppl.NewsCategorys.Dto;
using ppl.NewsManger;
using ppl.NewsManger.Dto;
using ppl.NewsTag;
using ppl.NewsTag.Dto;
using ppl.Users.Dto;
using ppl.Web.Models.NewsManger.NewsList;

namespace ppl.Web.Mvc.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_NewsManger)]
    public class NewsController : pplControllerBase
    {
        private readonly INewsMangerAppService _newsMangerAppService;
        private readonly INewsCategoryAppService _categoryAppService;
        private readonly INewsTagAppService _newsTagAppService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager _userManager;
        public NewsController(
            INewsMangerAppService newsMangerAppService,
            INewsCategoryAppService categoryAppService,
            INewsTagAppService newsTagAppService,
            IHostingEnvironment hostingEnvironment,
            UserManager userManager
            )
        {
            _newsMangerAppService = newsMangerAppService;
            _categoryAppService = categoryAppService;
            _newsTagAppService = newsTagAppService;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> NewsIndex(PageRequestBase input)
        {
            var model =_newsMangerAppService.GetAll().Where(x => x.Title.Contains(input.SearchedName)).OrderByDescending(x => x.PageView).ToList();
            model = model.Skip(input.SkipCount).Take(input.PageSize).ToList();
            NewsCategoryDto newsCategory=new NewsCategoryDto();
            model.ForEach(async s =>
            {
                newsCategory =this.ObjectMapper.Map(_categoryAppService.GetAll().FirstOrDefault(x => x.Id == s.Id),newsCategory);
                s.Author =ObjectMapper.Map<UserDto>(await this._userManager.GetUserByIdAsync(s.UserId));
            });
            var categorylist =_categoryAppService.GetAll();
            var tagslist = await _newsTagAppService.GetAll();
            var list = new NewsListViewModel()
            {
                NewsList = model,
                newsCategoryDtos=this.ObjectMapper.Map<List<NewsCategoryDto>>(categorylist),
                TotalCount=model.Count,
                PageIndex=input.PageIndex,
                TotalPageCount=input.PageCount,
                HasNextPage=input.NextPage,
                HasPreviousPage=input.HasPreviousPage,
                PageSize=input.PageSize,
                tags= this.ObjectMapper.Map<List<TagDto>>(tagslist),
            };
            return View(list);
        }
        public async Task<ActionResult> EditModel(Guid Id)
        {
            var output = await _newsMangerAppService.GetNewsEdit(new Abp.Application.Services.Dto.EntityDto<Guid>(Id));
            var model = new EditNewsViewModel(output);
            return View("_EditNewsModal",model);
        }
        [HttpPost]
        public async Task<IActionResult> Uploading(string L)
        {
            string urlname = "";
            var image = Request.Form.Files;
            if (image != null)
            {
                foreach(var file in image)
                {
                    var filename = file.FileName;
                    var path = string.Format("{0}/{1}",_hostingEnvironment.WebRootPath, "images/newsimages");
                    var url = Path.Combine(path, filename);
                    foreach (var img in Directory.GetFiles(path))
                    {
                        if (img.Equals(url))
                        {
                            urlname = "选择的图片已存在，请勿上传！";
                            return Json(urlname);
                        }
                    }
                    using (FileStream fs = System.IO.File.Create(url))
                    {
                        await file.CopyToAsync(fs);
                        fs.Flush();
                        fs.Close();
                        urlname = string.Format("{0}/{1}",path,filename);
                    }
                }
            }
            return Json(urlname);
        }
    }
}