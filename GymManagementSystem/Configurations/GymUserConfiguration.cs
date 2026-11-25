using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            //builder.Property(X => X.CreatedAt).HasDefaultValueSql("GetDate()");

            builder.Property(N => N.Name)
                   .HasColumnType("Varchar")
                   .HasMaxLength(50);

            builder.Property(E => E.Email)
                   .HasColumnType("Varchar")
                   .HasMaxLength(100);
            builder.HasIndex(E => E.Email).IsUnique();


            builder.Property(P => P.Phone)
                   .HasColumnType("Varchar")
                   .HasMaxLength(11);
            builder.HasIndex(P=>P.Phone).IsUnique();

            builder.ComplexProperty(A => A.Address);

            builder.ToTable(T=>
            {
                T.HasCheckConstraint("GymUser_EmailFormat", "Email like '_%@_%._%' ");
                T.HasCheckConstraint("GymUser_PhoneFormat", "Len(Phone) = 11 and (Phone like '010%' or Phone like '011%' or Phone like '012%' or Phone like '015%')");

            });
        }

    }
}
