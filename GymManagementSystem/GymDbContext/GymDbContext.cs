using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagementSystem.Data
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database=GymDbOnLine; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DbSets
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Membership> Memberships { get; set; }

        #endregion




    }
}

