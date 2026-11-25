using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Plan_DurationDaysCheck", "DurationDays between 1 and 365");
            });
        }
    }
}
