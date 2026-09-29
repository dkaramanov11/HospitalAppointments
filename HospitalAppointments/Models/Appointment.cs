using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalAppointments.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Display(Name = "Пациент")]
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        [Display(Name = "Лекар")]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        [Required]
        [Display(Name = "Датум и време на преглед")]
        public DateTime ScheduledAt { get; set; }
    }
}