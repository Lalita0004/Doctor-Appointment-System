using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Project.Models
{
    public class Appointment
    {
        [Key]

        public int Id { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        // --- NAYE FIELDS ---
        public int? TimeSlotId { get; set; }
        [ForeignKey("TimeSlotId")]
        public TimeSlot TimeSlot { get; set; }
            
        // e.g., "Pending", "Confirmed", "Completed", "Cancelled"
        public string Status { get; set; } = "Pending";

        [Display(Name = "Problem Description")]
        public string ProblemDescription { get; set; }
    }
}