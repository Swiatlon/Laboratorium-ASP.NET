using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="You need to enter name")]
        [StringLength(maximumLength:50, ErrorMessage = "Reached maximum char length")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
    }
}
