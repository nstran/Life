using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Life.Authorization.Roles;
using Life.Authorization.Users;
using Life.MultiTenancy;

namespace Life.EntityFrameworkCore
{
    public class LifeDbContext : AbpZeroDbContext<Tenant, Role, User, LifeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LifeDbContext(DbContextOptions<LifeDbContext> options)
            : base(options)
        {
        }
    }
}
