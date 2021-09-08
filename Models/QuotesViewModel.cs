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
        public string ImageLink { get; set; }
    }
    public class Datastore
    {
        public static List<QuotesViewModel> Quotes = new List<QuotesViewModel>
        {
            new QuotesViewModel{ Author = "Maadara Uchiha", Quotes = "The longer you live… The more you realize that reality is just made of pain, suffering and emptiness.", ImageLink = "https://www.pngfind.com/pngs/m/144-1447977_madara-uchiha-png-transparent-png.png" },
            new QuotesViewModel{ Author = "Nagato Pain", Quotes = "If you don’t share someone’s pain, you can never understand them.", ImageLink = "https://www.pngarea.com/pngm/549/3898761_naruto-characters-png-anime-animeboy-animeboys-naruto-shippuden.png"},
            new QuotesViewModel { Author = "Itachi Uchiha", Quotes = "Even the strongest of opponents always has a weakness.", ImageLink = "https://www.pngkit.com/png/detail/137-1374984_naruto-uchiha-itachi-cosplay-3-loops-necklace-anime.png"}
        };

        public static QuotesViewModel GetRandomQuotes()
        {
            var quotes = Quotes[new Random().Next(Quotes.Count)];
            return quotes;
        }
    }
}
