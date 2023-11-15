namespace RESTful_API.Entities
{
    public class Patient
    {
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
