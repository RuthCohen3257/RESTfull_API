using Microsoft.AspNetCore.Mvc;
using RESTful_API.Entities;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTful_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
       static List<Appointment> appointments= new List<Appointment>();
        int count = 0;
        // GET: api/<TurnController>
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return appointments;
        }

        // GET api/<TurnController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return appointments.Find(p => p.Id == id); ;
        }

        // POST api/<TurnController>
        [HttpPost]
        public void Post([FromBody] Appointment appointment)
        {
            appointments.Add(new Appointment { Id= count++,Doctor= appointment.Doctor,
            Patient=appointment.Patient,DateTime=appointment.DateTime});    
        }

        // PUT api/<TurnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment appointment)
        {
            Appointment app = appointments.Find(e => e.Id == id);
            if (app != null)
            {
                app.Id = appointment.Id;
                app.DateTime = appointment.DateTime;
                app.Patient = appointment.Patient;
                app.Doctor = appointment.Doctor;
            }
        }

        // DELETE api/<TurnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            appointments.Remove(appointments.Find(e => e.Id == id));
        }
    }
}
