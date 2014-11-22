using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace EmpireSecurityServices.Models
{
    public class Resume
    {
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Display(Name = "Contact No")]
        [Required]
        public string ContactNo { get; set; }
        [Display(Name = "Cover Latter")]
        public string CoverLetter { get; set; }
    }
}