using System;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using ppl.EntityFrameworkCore.Seed.Host;
using ppl.EntityFrameworkCore.Seed.Tenants;
using ppl.EntityFrameworkCore.Seed.WebSetting;

namespace ppl.EntityFrameworkCore.Seed
{ 
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<pplDbContext>(iocResolver, SeedHostDb);
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="context"></param>
        public static void SeedHostDb(pplDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            // Host seed
            new InitialHostDbBuilder(context).Create();

            // Default tenant seed (in host database).
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();
            //WebSETTING

            new DefaultWebSettingsBuilder(context).Create();
        }
        /// <summary>
        /// 上下文注册类
        /// </summary>
        /// <typeparam name="TDbContext"></typeparam>
        /// <param name="iocResolver"></param>
        /// <param name="contextAction"></param>
        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}
