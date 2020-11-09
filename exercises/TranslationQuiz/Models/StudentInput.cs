using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TranslationQuiz.Models
{
    public class StudentInput
    {
        [Required(ErrorMessage = "Please enter your First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last address")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Student ID")]
        public string StudentID { get; set; }

        public bool? IAmDone { get; set; }
    }
}
