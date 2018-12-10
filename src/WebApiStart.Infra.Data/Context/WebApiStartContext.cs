using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApiStart.Infra.Data.Mappings;
using WebApiStart.Domain.Models;

namespace WebApiStart.Infra.Data.Context
{
    public class WebApiStartContext : DbContext
    {
        public WebApiStartContext() : base(@"Server=(localdb)\v11.0;Database=StartDB;Trusted_Connection=Yes;")
        //base(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=optoDb;Trusted_Connection=Yes;")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;

            Database.CommandTimeout = 900;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WebApiStartContext>(null);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(8000));

            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
