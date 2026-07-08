using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Project.Models
{
    public class DoctorSchedule
    {
        [Key]
        public int Id { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        [Microsoft.AspNetCore.Mvc.ModelBinding.Validation.ValidateNever]
        public Doctor Doctor { get; set; }

        [Required]
        [Display(Name = "Day of Week")]
        public DayOfWeek AvailableDay { get; set; } // e.g., Monday, Tuesday

        [Required]
        [Display(Name = "Start Time")]
        public TimeSpan ShiftStartTime { get; set; } // e.g., 10:00 AM

        [Required]
        [Display(Name = "End Time")]
        public TimeSpan ShiftEndTime { get; set; } // e.g., 02:00 PM

        // Agar doctor chhutti par hai toh isko false kar denge
        public bool IsActive { get; set; } = true;
    }
}
