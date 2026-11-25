using GymManagementSystem.Entities.Enum;

namespace GymManagementSystem.Entities
{
    public class Trainer:GymUser
    {
        public DateTime HireDate { get; set; }

        public Specialties Specialties { get; set; }

        //Property Navigation (1 Trainer M Sessions)
        public ICollection<Session> Sessions { get; set; } = default!;

    }
}
