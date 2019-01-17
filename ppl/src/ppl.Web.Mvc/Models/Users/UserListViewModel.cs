using System.Collections.Generic;
using ppl.Roles.Dto;
using ppl.Users.Dto;

namespace ppl.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
