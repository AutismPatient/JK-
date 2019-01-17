using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ppl.EntityFrameworkCore
{
    public static class pplDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<pplDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString,b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<pplDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
