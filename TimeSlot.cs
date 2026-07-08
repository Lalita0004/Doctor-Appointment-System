using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Project.Models
{
    public class TimeSlot
    {
        [Key]
        public int Id { get; set; }

        public int DoctorScheduleId { get; set; }
        [ForeignKey("DoctorScheduleId")]
        public DoctorSchedule DoctorSchedule { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        // Jab patient slot book kar lega, toh ye true ho jayega
        public bool IsBooked { get; set; } = false;
    }
}
