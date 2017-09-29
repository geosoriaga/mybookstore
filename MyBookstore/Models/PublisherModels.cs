using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyBookstore.Models
{
    public class PublisherModels
    {
        [Key]

        public int ID { get; set; }

        [Display(Name = "Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only!")]
        [Required(ErrorMessage = "Form needs to be filled")]
        public string Name { get; set; }



    }
}