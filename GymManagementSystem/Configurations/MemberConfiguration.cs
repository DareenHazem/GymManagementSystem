using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Configurations
{
    public class MemberConfiguration : GymUserConfiguration<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql(sql: "GETDATE()")
                   .HasColumnName(name: "JoinDate");

            base.Configure(builder);
        }
    }
}
