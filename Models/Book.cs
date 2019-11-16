using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Book name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Copy")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int copy { get; set; }
    }
}