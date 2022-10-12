using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VirtoCommerce.Platform.Security.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SecurityDbContext>
    {
        public SecurityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SecurityDbContext>();

            builder.UseMySql("server=localhost;user=root;password=virto;database=VirtoCommerce3;", new MySqlServerVersion(new Version(5, 7)));
            builder.UseOpenIddict();
            return new SecurityDbContext(builder.Options);
        }
    }
}
