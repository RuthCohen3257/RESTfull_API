namespace RESTful_API.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
