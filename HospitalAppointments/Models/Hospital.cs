using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalAppointments.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public string Image { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}