using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace Laboratorium_3.Models
{
    public class ProductModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana.")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa niż 0.")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Producent jest wymagany.")]
        public string Producent { get; set; }

        [Required(ErrorMessage = "Data produkcji jest wymagana.")]
        [DataType(DataType.Date, ErrorMessage = "Wprowadź prawidłową datę produkcji.")]
        public DateTime DataProdukcji { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Opis musi mieć co najmniej 10 i nie więcej niż 1000 znaków.")]
        public string Opis { get; set; }
    }
}
