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
        public string name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int copy { get; set; }
    }
}