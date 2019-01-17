using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ppl.Authorization.Roles;
using ppl.Authorization.Users;
using ppl.MultiTenancy;
using ppl.New;
using ppl.NewsTag;
using ppl.NewsCategorys;
using ppl.NewsAndTag;
using ppl.WebSettings;
using ppl.FeedBack;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ppl.EntityFrameworkCore
{
    public class pplDbContext : AbpZeroDbContext<Tenant, Role, User, pplDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public pplDbContext(DbContextOptions<pplDbContext> options)
            : base(options)
        {
        }
        //资料
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> Categories { get; set; }
        public DbSet<NewsTags> NewsTags { get; set; }
        public DbSet<NewAndTag> newAndTags { get; set; }
        public DbSet<WebSetting> WebSettings { get; set; }
        public DbSet<FeedBacks> FeedBack { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewAndTag>().HasKey(x => new { x.NewsId, x.TagId });
        }
        /// <summary>
        /// 有条件地永久删除实体记录
        /// </summary>
        /// <param name="entry"></param>
        protected override void CancelDeletionForSoftDelete(EntityEntry entry)
        {
            if (IsSoftDeleteFilterEnabled)
            {
                base.CancelDeletionForSoftDelete(entry);
            }
        }
    }
}
