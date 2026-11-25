using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(x => x.Id); // Surrogate Key not Composite Key
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GetDate()");
            //builder.Property(X => X.StartDate).HasDefaultValueSql("GetDate()");


            builder.HasOne(Ms=> Ms.Plan)
                   .WithMany(P=> P.PlanSubscribitions)
                   .HasForeignKey(Ms=> Ms.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(Ms => Ms.Member)
                  .WithMany(M => M.MemberSubscribitions)
                  .HasForeignKey(Ms => Ms.MemberId)
                  .OnDelete(DeleteBehavior.Restrict);

           builder.Ignore(x => x.Status);
        }
    }
}
