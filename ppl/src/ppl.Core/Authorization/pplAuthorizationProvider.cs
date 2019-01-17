using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ppl.Authorization
{
    //权限提供器
    public class pplAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var user= context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            var role= context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            var tenant= context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            var news= context.CreatePermission(PermissionNames.Pages_NewsManger, L("NewsManagments"), multiTenancySides: MultiTenancySides.Host);
            var tag= context.CreatePermission(PermissionNames.Pages_Tags, L("NewsTags"));
            var parameter= context.CreatePermission(PermissionNames.Pages_WebParameter, L("WebParameter"), multiTenancySides: MultiTenancySides.Host);
            var category= context.CreatePermission(PermissionNames.Pages_Category, L("NewsCategory"), multiTenancySides: MultiTenancySides.Host);
            var about= context.CreatePermission(PermissionNames.Pages_About, L("About"), multiTenancySides: MultiTenancySides.Host);
            var feedback= context.CreatePermission(PermissionNames.Pages_FeedBack, L("FeedBack"), multiTenancySides: MultiTenancySides.Host);
            var zore = context.CreatePermission(PermissionNames.Pages_ZoreAbout, L("ZoreAbout"));
            var language = context.CreatePermission(PermissionNames.Page_Language, L("Language"));

            //操作项权限
            user.CreateChildPermission(PermissionNames.Pages_CreateUsers, L("CreateUser"));
            role.CreateChildPermission(PermissionNames.Pages_CreateRoles,L("CreateRole"));
            category.CreateChildPermission(PermissionNames.Pages_CreateCategory, L("CreateCategory"));
            news.CreateChildPermission(PermissionNames.Pages_CreateData, L("CreateData"));
            tag.CreateChildPermission(PermissionNames.Pages_CreateTag, L("CreateTag"));
            tenant.CreateChildPermission(PermissionNames.Pages_CreateTenant, L("CreateTenant"));

            user.CreateChildPermission(PermissionNames.Pages_UpdateUsers, L("UpdateUsers"));
            role.CreateChildPermission(PermissionNames.Pages_UpdateRoles, L("UpdateRoles"));
            category.CreateChildPermission(PermissionNames.Pages_UpdateCategory, L("UpdateCategory"));
            news.CreateChildPermission(PermissionNames.Pages_UpdateData, L("UpdateData"));
            tag.CreateChildPermission(PermissionNames.Pages_UpdateTag, L("UpdateTag"));
            tenant.CreateChildPermission(PermissionNames.Pages_UpdateTenant, L("UpdateTenant"));
            parameter.CreateChildPermission(PermissionNames.Pages_EditWebSetting, L("EditWebSetting"));
            feedback.CreateChildPermission(PermissionNames.Pages_SeedEmail, L("SeedEmail"));

            user.CreateChildPermission(PermissionNames.Pages_DeleteUsers, L("DeleteUsers"));
            role.CreateChildPermission(PermissionNames.Pages_DeleteRoles, L("DeleteRoles"));
            category.CreateChildPermission(PermissionNames.Pages_DeleteCategory, L("DeleteCategory"));
            news.CreateChildPermission(PermissionNames.Pages_DeleteData, L("DeleteData"));
            tag.CreateChildPermission(PermissionNames.Pages_DeleteTag, L("DeleteTag"));
            tenant.CreateChildPermission(PermissionNames.Pages_DeleteTenant, L("DeleteTenant"));
            feedback.CreateChildPermission(PermissionNames.Pages_DeleteFeedBack, L("DeleteFeedBack"));

        }
        /// <summary>
        /// 本地化提供器
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, JklConsts.LocalizationSourceName);
        }
    }
}
