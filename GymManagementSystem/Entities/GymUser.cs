namespace GymManagementSystem.Entities
{
    public abstract class GymUser:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public DateTime DOB { get; set; }
        public string Gender { get; set; } = default!;
    }
}
