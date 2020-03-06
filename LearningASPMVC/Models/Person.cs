using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LearningASPMVC.Models
{
    public class Person
    {
        [Required(ErrorMessage ="you must input name")]
        public string FirstName { set; get; }
        [Required(ErrorMessage ="must input")]
        public string LastName { set; get; }
        
        public int Age { set; get; }
        public string Email { set; get; }

    }
}