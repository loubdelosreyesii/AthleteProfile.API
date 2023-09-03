using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleteProfile.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<AthleteProfileDbContext>
    {
        //public ApplicationDbContext CreateDbContext(string[] args)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EcommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true");

        //    return new ApplicationDbContext(optionsBuilder.Options);
        //}
        public AthleteProfileDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AthleteProfileDbContext>();
            var connectionString = "Data Source=X2MO;Initial Catalog=AthleteProfileDB;User ID=sa;Password=Passw0rd01;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString);

            return new AthleteProfileDbContext(optionsBuilder.Options);
        }
    }
}
