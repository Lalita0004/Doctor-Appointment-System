using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Project.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        // Kis appointment ki payment hai?
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        [Required]
        public double TotalAmount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; } // Example: UPI, Cash, Card

        public string PaymentStatus { get; set; } = "Pending"; // Pending, Paid, Failed
    }
}
