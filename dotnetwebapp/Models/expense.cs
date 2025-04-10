using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Finance.Models  {
        public class Expense{
            public int Id {get; set;}
            [Required]
            public string Description {get; set;} = null!;
            [Required]
            [Range( 0.01, Double.MaxValue, ErrorMessage = "Amount needs to be higher than 0")]
            public double Amount {get; set;}
            [Required]
            public string Category {get; set;} = null!;
            public DateTime date {get; set;} = DateTime.Now;
        }


}