namespace GymManagementSystem.Entities
{
    public class Session:BaseEntity
    {
        public int Capacity { get; set; }
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Property Navigation (1 Trainer M Sessions)
        public Trainer Trainer { get; set; } = default!;
        public int TrainerId { get; set; }

    }
}
