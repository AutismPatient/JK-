namespace ppl.Authorization
{
    /// <summary>
    /// 权限常量定义
    /// </summary>
    public static class PermissionNames
    {
        public const string Pages_Tenants = "Pages.Tenants";

        public const string Pages_Users = "Pages.Users";

        public const string Pages_Roles = "Pages.Roles";

        public const string Pages_NewsManger = "Pages.NewsManger";

        public const string Pages_Category = "Pages.Category";

        public const string Pages_Tags = "Pages.Tags";

        public const string Pages_FeedBack = "Pages.FeedBack";

        public const string Pages_About = "Pages.About";

        public const string Pages_WebParameter = "Pages.WebParameter";
        public const string Page_Language = "Page.Language";


        #region 资料操作
        public const string Pages_CreateData = "Pages.CreateData";

        public const string Pages_DeleteData = "Pages.DeleteData";

        public const string Pages_UpdateData = "Pages.UpdateData";
        #endregion

        #region 类别项操作
        public const string Pages_CreateCategory = "Pages_CreateCategory";
        public const string Pages_DeleteCategory = "Pages_DeleteCategory";
        public const string Pages_UpdateCategory = "Pages_UpdateCategory";
        #endregion

        #region 标签操作
        public const string Pages_CreateTag = "Pages_CreateTag";
        public const string Pages_DeleteTag = "Pages_DeleteTag";
        public const string Pages_UpdateTag = "Pages_UpdateTag";
        #endregion


        #region 意见反馈操作
        public const string Pages_SeedEmail = "Pages_SeedEmail";
        public const string Pages_DeleteFeedBack = "Pages_DeleteFeedBack";
        #endregion


        #region 站点设置操作
        public const string Pages_EditWebSetting = "Pages_EditWebSetting";
        #endregion

        #region 用户操作
        public const string Pages_CreateUsers = "Pages_CreateUsers";
        public const string Pages_DeleteUsers = "Pages_DeleteUsers";
        public const string Pages_UpdateUsers = "Pages_UpdateUsers";
        #endregion


        #region 角色操作
        public const string Pages_CreateRoles = "Pages_CreateRoles";
        public const string Pages_DeleteRoles = "Pages_DeleteRoles";
        public const string Pages_UpdateRoles = "Pages_UpdateRoles";
        #endregion

        #region 租户操作
        public const string Pages_CreateTenant = "Pages_CreateTenant";
        public const string Pages_DeleteTenant = "Pages_DeleteTenant";
        public const string Pages_UpdateTenant = "Pages_UpdateTenant";
        #endregion

        #region asp.net zore
        public const string Pages_ZoreAbout = "Pages.ZoreAbout";
        #endregion
    }
}
