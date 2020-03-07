using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingValidationS.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name = "Job applicant name")]
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please select your sex")]
        public string Sex { get; set; }

        [Range(0, 5)]
        public int Experience { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the Terms")]
        public bool TermsAccepted { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
    }
}
