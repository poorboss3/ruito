using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ruito.Authorization.Roles;
using ruito.Authorization.Users;
using ruito.MultiTenancy;

namespace ruito.EntityFrameworkCore
{
    public class ruitoDbContext : AbpZeroDbContext<Tenant, Role, User, ruitoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ruitoDbContext(DbContextOptions<ruitoDbContext> options)
            : base(options)
        {
        }
    }
}
