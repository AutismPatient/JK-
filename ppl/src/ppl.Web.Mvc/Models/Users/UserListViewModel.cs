using System.Collections.Generic;
using ppl.Roles.Dto;
using ppl.Users.Dto;
using ppl.Web.Models.Common;

namespace ppl.Web.Models.Users
{
    public class UserListViewModel<TUsers,TRoles>:ViewModelBase<TUsers> where TUsers:class where TRoles:class
    {
        public UserListViewModel(PageReturnDto<TUsers> dto,IReadOnlyList<TRoles> roles):base(dto)
        {
            Users=dto.EntityItems;
            Roles = roles;
        }
        public IReadOnlyList<TUsers> Users { get; set; }

        public IReadOnlyList<TRoles> Roles { get; set; }
    }
}
