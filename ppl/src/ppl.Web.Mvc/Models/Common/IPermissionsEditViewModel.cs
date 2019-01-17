using System.Collections.Generic;
using ppl.Roles.Dto;

namespace ppl.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}