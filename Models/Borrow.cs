using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        [Required]
        public int bookId { get; set; }
        public Book Book { get; set; }
        [Required]
        public int clientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public DateTime borrowDate { get; set; }
        [Required]
        public DateTime returnDate { get; set; }
    }
}