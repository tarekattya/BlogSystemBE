using Infrastructure.Persistence.Emtities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(new ApplicationRole
            {
                Id = DefaultRoles.AdminRoleId,
                Name = DefaultRoles.Admin,
                NormalizedName = DefaultRoles.Admin.ToUpper(),
                ConcurrencyStamp = DefaultRoles.AdminRoleConcurrencyStamp,

            },
            new ApplicationRole
            {
                Id = DefaultRoles.AuthorRoleId,
                Name = DefaultRoles.Author,
                NormalizedName = DefaultRoles.Author.ToUpper(),
                ConcurrencyStamp = DefaultRoles.AuthorRoleConcurrencyStamp,
                IsDefault = true
            },
            new ApplicationRole
            {
                Id = DefaultRoles.ReaderRoleId,
                Name = DefaultRoles.Reader,
                NormalizedName = DefaultRoles.Reader.ToUpper(),
                ConcurrencyStamp = DefaultRoles.ReaderRoleConcurrencyStamp,
            });
        }
    }
}
