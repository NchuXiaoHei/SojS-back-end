using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SojS.BackEnd.Authorization.Roles;
using SojS.BackEnd.Authorization.Users;
using SojS.BackEnd.MultiTenancy;

namespace SojS.BackEnd.EntityFrameworkCore
{
    public class BackEndDbContext : AbpZeroDbContext<Tenant, Role, User, BackEndDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BackEndDbContext(DbContextOptions<BackEndDbContext> options)
            : base(options)
        {
        }
    }
}
