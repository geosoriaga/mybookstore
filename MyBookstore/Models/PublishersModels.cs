using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class PublishersModels
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Publisher Name")]
        [MaxLength(40, ErrorMessage = "40 characters lang sir")]
        [Required(ErrorMessage = "Required")]
        public string PubName { get; set; }
    }
}