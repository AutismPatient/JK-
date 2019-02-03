using System.Collections.Generic;
using ppl.Roles.Dto;
using ppl.Web.Models.Common;

namespace ppl.Web.Models.Roles
{
    public class RoleListViewModel<T,TPermissions>:ViewModelBase<T> where T:class where TPermissions:class
    {
        public RoleListViewModel(PageReturnDto<T> page,IReadOnlyList<TPermissions> permissions):base(page)
        {
            Roles = page.EntityItems;
            Permissions = permissions;
        }
        public IReadOnlyList<T> Roles { get; set; }

        public IReadOnlyList<TPermissions> Permissions { get; set; }
    }
}
