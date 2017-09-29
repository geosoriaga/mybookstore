using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class AuthorsModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Last Name")]
        [MaxLength(40, ErrorMessage = "40 characters lang sir")]
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }


        [Display(Name = "First Name")]
        [MaxLength(20, ErrorMessage = "20 characters lang sir")]
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }


        [Display(Name = "Phone")]
        [MaxLength(12, ErrorMessage = "12 characters lang sir")]
        [Required(ErrorMessage = "Required")]
        public string Phone { get; set; }


        [Display(Name = "Address")]
        [MaxLength(40, ErrorMessage = "40 characters lang sir")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }


        [Display(Name = "City")]
        [MaxLength(20, ErrorMessage = "20 characters lang sir")]
        public string City { get; set; }


        [Display(Name = "State")]
        [MaxLength(2, ErrorMessage = "2 characters lang sir")]
        public string State { get; set; }


        [Display(Name = "Zip Code")]
        [MaxLength(5, ErrorMessage = "5 characters lang sir")]
        public string Zip { get; set; }

    }
}