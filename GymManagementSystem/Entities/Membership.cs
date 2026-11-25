namespace GymManagementSystem.Entities
{
    public class Membership:BaseEntity
    {
        public DateTime StartDate { get; set; } // Attribute on Relationship
        public DateTime EndDate { get; set; } // Attribute on Relationship

        public String Status => StartDate > DateTime.Now ? "Upcoming" : EndDate > DateTime.Now ? "Active" : "Expired";

        //Property Navigation (1 Member M Memberships)
        public Member Member { get; set; } = default!;
        public int MemberId { get; set; }

        //Property Navigation (1 Plan M Memberships)
        public Plan Plan { get; set; } = default!;
        public int PlanId { get; set; }
    }
}
