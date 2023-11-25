using RESTful_API.Entities;

namespace RESTful_API
{
    public class DataContext
    {
        public List<Appointment> Appointmens { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
