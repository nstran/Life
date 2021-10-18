using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Life.EntityFrameworkCore
{
    public static class LifeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LifeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LifeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
