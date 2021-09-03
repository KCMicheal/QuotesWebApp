using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesWebApp.Models
{
    public class QuotesViewModel
    {
        [Required(ErrorMessage = "A Shinobi's name is required!")]
        public string Author { get; set; }
        [Required(ErrorMessage = "A Quote is required!")]
        public string Quotes { get; set; }

      
    }
}
