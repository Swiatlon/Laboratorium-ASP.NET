using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Models.Product
{
    public class Product
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Producer field is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Producer must be between 2 and 50 characters.")]
        public string Producer { get; set; }

        [Required(ErrorMessage = "The Production Date field is required.")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime ProductionDate { get; set; }

        [StringLength(maximumLength: 255, ErrorMessage = "You reached the maximum amount of description length.")]
        public string Description { get; set; }

    }
}
