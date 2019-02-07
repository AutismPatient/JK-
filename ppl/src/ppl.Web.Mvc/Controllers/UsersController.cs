using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using ppl.Authorization;
using ppl.Controllers;
using ppl.Users;
using ppl.Web.Models.Users;
using ppl.Users.Dto;
using ppl.Roles.Dto;

namespace ppl.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : pplControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index(PageRequestInput input)
        {
            var users =  _userAppService.GetAlls();
            var roles = (await _userAppService.GetRoles()).Items;
            var dto = new PageReturnDto<UserDto>(users, input.PageIndex, input.PageSize);
            return View(new UserListViewModel<UserDto,RoleDto>(dto,roles));
        }

        public async Task<ActionResult> EditUserModal(long userId)
        {
            var user = await _userAppService.Get(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return View("_EditUserModal", model);
        }
    }
}
