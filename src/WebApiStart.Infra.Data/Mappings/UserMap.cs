using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStart.Domain.Models;

namespace WebApiStart.Infra.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.UserName)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Password)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
