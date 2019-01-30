using Abp.Application.Navigation;
using Abp.Localization;
using ppl.Authorization;

namespace ppl.Web.Startup
{
    /// <summary>
    /// 菜单定义
    /// </summary>
    public class pplNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home"
                    )
                )
                .AddItem(
                new MenuItemDefinition(
                    PageNames.NewsManagments,
                    L("DataManagementCenter"),
                    icon: "apps"
                    )
                    .AddItem(
                    new MenuItemDefinition(
                        "NewsList",
                        L("DatabaseManagement"),
                        url: "/News/NewsIndex",
                        requiredPermissionName:PermissionNames.Pages_NewsManger
                        ))
                        .AddItem(
                    new MenuItemDefinition(
                            "NewsTags",
                            L("LabelItem"),
                            url:"/NewsTags/Index",
                            requiredPermissionName:PermissionNames.Pages_Tags
                            ))
                            .AddItem(
                    new MenuItemDefinition(
                            "NewsCategory",
                            L("CategoryItem"),
                            url: "/NewsCategorys/Index",
                            requiredPermissionName:PermissionNames.Pages_Category
                            ))
                    )
                    .AddItem(new MenuItemDefinition(
                        PageNames.WebSettings,
                        L("WebManger"),
                        icon: "language"
                        )
                        .AddItem(new MenuItemDefinition(
                            "WebParameter",
                            L("WebParameter"),
                            url: "/WebSetting/EditForWeb",
                            requiredPermissionName:PermissionNames.Pages_WebParameter
                            ))
                            .AddItem(new MenuItemDefinition(
                                "FeedBack",
                                L("FeedBack"),
                                url:"/FeedBack",
                                requiredPermissionName:PermissionNames.Pages_FeedBack
                                ))
                        )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "business",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info",
                        requiredPermissionName:PermissionNames.Pages_About
                    )
                ).AddItem(new MenuItemDefinition(
                    PageNames.Language,
                    L("Language"),
                    url:"Languages",
                    icon: "g_translate",
                    requiredPermissionName:PermissionNames.Page_Language
                    )
                )
                .AddItem( // Menu items below is just for demonstration!
                    new MenuItemDefinition(
                        "MultiLevelMenu",
                        L("MultiLevelMenu"),
                        icon: "menu"
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplate",
                            new FixedLocalizableString("ASP.NET Boilerplate")
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateHome",
                                new FixedLocalizableString("Home"),
                                url: "https://aspnetboilerplate.com?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateTemplates",
                                new FixedLocalizableString("Templates"),
                                url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateSamples",
                                new FixedLocalizableString("Samples"),
                                url: "https://aspnetboilerplate.com/Samples?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateDocuments",
                                new FixedLocalizableString("Documents"),
                                url: "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl"
                            )
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZero",
                            new FixedLocalizableString("ASP.NET Zero")
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroHome",
                                new FixedLocalizableString("Home"),
                                url: "https://aspnetzero.com?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroDescription",
                                new FixedLocalizableString("Description"),
                                url: "https://aspnetzero.com/?ref=abptmpl#description"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroFeatures",
                                new FixedLocalizableString("Features"),
                                url: "https://aspnetzero.com/?ref=abptmpl#features"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroPricing",
                                new FixedLocalizableString("Pricing"),
                                url: "https://aspnetzero.com/?ref=abptmpl#pricing"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroFaq",
                                new FixedLocalizableString("Faq"),
                                url: "https://aspnetzero.com/Faq?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroDocuments",
                                new FixedLocalizableString("Documents"),
                                url: "https://aspnetzero.com/Documents?ref=abptmpl"
                            )
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, JklConsts.LocalizationSourceName);
        }
    }
}
