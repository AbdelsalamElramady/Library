using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int copy { get; set; }
    }
}