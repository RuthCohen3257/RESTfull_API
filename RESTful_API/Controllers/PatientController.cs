﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RESTful_API.Entities;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTful_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly List<Patient> _dataContext;

        public PatientController(DataContext dataContext)
        {
            var app = new List<Appointment>();
            _dataContext = dataContext.Patients;

        }
       
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _dataContext;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return _dataContext.Find(p=>p.IdNumber == id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            _dataContext.Add(new Patient
            {
                IdNumber = patient.IdNumber,
                Name = patient.Name,
                DateBorn = patient.DateBorn,
                Address = patient.Address,
                PhoneNumber = patient.PhoneNumber
            });
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient patient)
        {
            Patient p = _dataContext.Find(e => e.IdNumber == id);
            if(p!= null)
            {
                p.Name = patient.Name;
                p.DateBorn = patient.DateBorn;
                p.Address = patient.Address;
                p.PhoneNumber = patient.PhoneNumber;
            }

        }

        [HttpPut("{id}/status")]
        public void Put(int id, [FromBody] Patient patient,bool status)
        {
            Patient pat = _dataContext.Find(p => p.IdNumber == id);
            if (pat != null)
                pat.Status = patient.Status;

        }

        // DELETE api/<PatientController>/5
        //[HttpDelete("{id}")]
        // public void Delete(int id)
        //{
        // }
    }
}
