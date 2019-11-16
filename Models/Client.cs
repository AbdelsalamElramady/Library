using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
    }
}