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
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Doctor ka naam zaroori hai")]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        public string Degree { get; set; }

        [Display(Name = "Clinic Name")]
        public string ClinicName { get; set; }

        public string ContactNumber { get; set; }

        public double Fees { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [ValidateNever]
        public Department Department { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
