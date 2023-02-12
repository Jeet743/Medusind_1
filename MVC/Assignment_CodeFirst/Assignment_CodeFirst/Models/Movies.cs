using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_CodeFirst.Models
{
    [Table("Movie")]
    public class Movies
    {
        [Key]   
        public int Mid { get; set; }

        [Required(ErrorMessage = "Movie Name Is Required..!!")]
        public string Moviename { get; set; }

        [Required(ErrorMessage = "Date Of Release Is Required..!!")]
        public DateTime DateofRelease { get; set;}

        
    }
}