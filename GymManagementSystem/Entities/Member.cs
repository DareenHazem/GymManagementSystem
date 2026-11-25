namespace GymManagementSystem.Entities
{
    public class Member:GymUser
    {
        public string? Photo { get; set; } 

        //Property Navigation (1 Member M Memberships)
        public ICollection<Membership> MemberSubscribitions { get; set; } = default!;

    }
}
