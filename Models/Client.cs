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
        [Display(Name = "Client name")]
        public string name { get; set; }
    }
}