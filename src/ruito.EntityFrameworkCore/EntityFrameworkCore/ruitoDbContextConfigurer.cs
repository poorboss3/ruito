using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ruito.EntityFrameworkCore
{
    public static class ruitoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ruitoDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));
        }

        public static void Configure(DbContextOptionsBuilder<ruitoDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}
