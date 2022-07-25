using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TidsregApi.Models
{
    public class Registrering
    {

        public string Date { get; set; }
        public int TimeUsed { get; set; }
        public string Customer { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }
        public string InternDescription { get; set; }

        public Registrering(string date, int timeUsed, string customer, string contactPerson, string description, string internDescription)
        {
            Date = date;
            TimeUsed = timeUsed;
            Customer = customer;
            ContactPerson = contactPerson;
            Description = description;
            InternDescription = internDescription;
        }

        public Registrering()
        {
        }
    }
}
