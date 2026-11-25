using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.ToTable(T=>
            {
                T.HasCheckConstraint("Session_CapacityCheck", "Capacity between 1 and 25");
                T.HasCheckConstraint("Session_EndDateCheck", "EndDate > StartDate");

            });

            builder.HasOne(T => T.Trainer)
                   .WithMany(S => S.Sessions)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
