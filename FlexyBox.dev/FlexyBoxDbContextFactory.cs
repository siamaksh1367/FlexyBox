using FlexyBox.dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FlexyBox.dev
{
    public class FlexyBoxDbContextFactory : IDesignTimeDbContextFactory<FlexyBoxDB>
    {
        public FlexyBoxDB CreateDbContext(string[] args)
        {
            Console.WriteLine("hello");

            var optionsBuilder = new DbContextOptionsBuilder<FlexyBoxDB>();
            var configuration = new ConfigurationBuilder()
           .AddEnvironmentVariables()
           .AddUserSecrets("368a681a-fad6-423c-83cd-010c88424176")
           .Build();
            Console.WriteLine(configuration.GetSection("SQLConnectionString").GetSection("ConnectionString").Value);
            optionsBuilder.UseSqlServer(configuration.GetSection("SQLConnectionString").GetSection("ConnectionString").Value, option => option.MigrationsAssembly("FlexyBox.dal"));

            return new FlexyBoxDB(optionsBuilder.Options);
        }
    }
}
