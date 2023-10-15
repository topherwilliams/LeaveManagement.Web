using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "e39144c2-984e-47fa-a70d-90623466cc7a",
                    UserId = "a59144c1-984e-47fa-a70d-90323466cc7a",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "e39144c2-984e-47fa-a70d-20623466cc9a",
                    UserId = "a59166c1-984e-47fa-a70d-90323422cc2a",
                }               
            ); ;
            //throw new NotImplementedException();
        }
    }
}