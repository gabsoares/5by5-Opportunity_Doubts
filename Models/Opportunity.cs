namespace Models
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string? SurgeLevel { get; set; }
        public int HoursAmount { get; set; }
        public long ErrorsAmount { get; set; }
        public long LearningLevel { get; set; }
        public long SleepHours { get; set; }
        public int OffHours { get; set; }
    }
}
