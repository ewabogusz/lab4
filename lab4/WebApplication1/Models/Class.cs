using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FilmModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        public string Title { get; set; }

        public int Year { get; set; }
    }
}
