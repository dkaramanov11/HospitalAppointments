using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalAppointments.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}