using Microsoft.AspNetCore.Mvc;
using RESTful_API.Entities;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTful_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly List<Doctor> _dataContext;

        public DoctorController(DataContext dataContext)
        {
            var app = new List<Appointment>();
            _dataContext = dataContext.Doctors;

        }

       private static int count = 0;
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _dataContext;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _dataContext.Find(e => e.Id == id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody]Doctor doctor)
        {
            _dataContext.Add(new Doctor { Id = count++, Name = doctor.Name, DateBorn=doctor.DateBorn,
                Address=doctor.Address, PhoneNumber=doctor.PhoneNumber 
            });
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor )
        {
            Doctor doc = _dataContext.Find(e => e.Id == id);
            if (doc != null)
            {
                doc.Name = doctor.Name;
                doc.DateBorn = doctor.DateBorn;
                doc.Address = doctor.Address;
                doc.PhoneNumber = doctor.PhoneNumber;
            }
        }

        [HttpPut("{id}/status")]
        public void Put(int id, [FromBody] Doctor doctor, bool status)
        {
            Doctor doc = _dataContext.Find(p => p.Id == id);
            if (doc != null)
                doc.Status = doctor.Status;

        }
        // DELETE api/<DoctorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
       // }
    }
}
