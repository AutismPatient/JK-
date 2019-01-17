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

        public async Task<IActionResult> NewsIndex(SeacrhNewsDto input)
        {
            input.PageIndex= input.PageIndex == null || input.PageIndex<0 ? 1 : input.PageIndex;
            input.PageSize = input.PageSize == null ? 15 : input.PageSize;
            input.SearchedName = input.SearchedName == null ? "" : input.SearchedName;
            var model =_newsMangerAppService.GetAll().Where(x => x.Title.Contains(input.SearchedName)).OrderByDescending(x => x.PageView).ToList();
            var count = model.Count();
            var PageCount = count / input.PageSize.Value;//总页数
            var dataMaxPageCount = (count % input.PageSize.Value) != 0;//判断是否整除（有余数就加一页）
            PageCount = dataMaxPageCount || PageCount==0 ? PageCount + 1 : PageCount;
            if (count != 0)
            {
                if (input.PageIndex > PageCount)
                {
                    input.PageIndex = PageCount;
                }
            }
            else
            {
                if (input.PageIndex > PageCount)
                {
                    input.PageIndex = 1;
                }
            }
            var HasNextPage = PageCount - input.PageIndex.Value > 0 ? true : false;//是否有下一页
            var HasPreviousPage = input.PageIndex != 1 ? true : false;
            model = model.Skip((input.PageIndex.Value - 1) * input.PageSize.Value).Take(input.PageSize.Value).ToList();
            NewsCategoryDto newsCategory=new NewsCategoryDto();
            model.ForEach(async s =>
            {
                newsCategory =this.ObjectMapper.Map(_categoryAppService.GetAll().Result.FirstOrDefault(x => x.Id == s.Id),newsCategory);
                s.Author =ObjectMapper.Map<UserDto>(await this._userManager.GetUserByIdAsync(s.UserId));
            });
            var categorylist =await _categoryAppService.GetAll();
            var tagslist = await _newsTagAppService.GetAll();
            
            var list = new NewsListViewModel()
            {
                NewsList = model,
                newsCategoryDtos=this.ObjectMapper.Map<List<NewsCategoryDto>>(categorylist),
                TotalCount=count,
                PageIndex=input.PageIndex.Value,
                TotalPageCount=PageCount,
                HasNextPage=HasNextPage,
                HasPreviousPage=HasPreviousPage,
                PageSize=input.PageSize.Value,
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
        public async Task<IActionResult>  Uploading(string L)
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
                        urlname ="../../images/newsimages/"+ filename;
                    }
                }
            }
            return Json(urlname);
        }
    }
}