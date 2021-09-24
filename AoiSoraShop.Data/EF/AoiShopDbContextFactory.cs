using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AoiSoraShop.Data.EF
{
    public class AoiShopDbContextFactory : IDesignTimeDbContextFactory<AoiShopDbContext>
    {
        public AoiShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("AoiShopDB");
            var optionsBuilder = new DbContextOptionsBuilder<AoiShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new AoiShopDbContext(optionsBuilder.Options);
        }
    }
}
