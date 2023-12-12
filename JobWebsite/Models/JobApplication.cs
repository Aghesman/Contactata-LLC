using System;
using System.ComponentModel.DataAnnotations;

namespace JobWebsite.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Keep Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Subject Matter")]
        public string SubjectMatter { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
