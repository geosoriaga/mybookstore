using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class AuthorModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only!")]
        [Required(ErrorMessage = "Form needs to be filled")]
        public string LN { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(20, ErrorMessage = "Up tp 20 characters only!")]
        [Required(ErrorMessage = "Form needs to be filled")]
        public string FN { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(12, ErrorMessage = "Up to 12 characters only!")]
        [Required(ErrorMessage = "Form needs to be filled")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only!")]
        public string Address { get; set; }

        [MaxLength(20, ErrorMessage = "Up to 20 characters only!")]
        [Display(Name = "City")]
        public string City { get; set; }

        [MaxLength(2, ErrorMessage = "Up to 2 characters only!")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(5, ErrorMessage = "Up to 5 characters only!")]
        public string Zip { get; set; }
    }
}