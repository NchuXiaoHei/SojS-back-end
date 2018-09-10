using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SojS.BackEnd.EntityFrameworkCore
{
    public static class BackEndDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BackEndDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BackEndDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
