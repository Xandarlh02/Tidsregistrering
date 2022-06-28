using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tidsreg_Api.Models
{
    public class RegistreringsModel
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public int TimeUsed { get; set; }
        public string Customer { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }
        public string InternDescription { get; set; }

    }
}
