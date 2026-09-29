using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalAppointments.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Име и презиме")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$",
            ErrorMessage = "Кодот мора да содржи точно 5 цифри.")]
        [Display(Name = "Код на пациент")]
        public string PatientCode { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
