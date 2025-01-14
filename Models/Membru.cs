using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;



namespace Proiect3._0.Models
{
    public class Membru
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage =
"Numele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")] 
        [StringLength(30, MinimumLength = 3)]
        public string? NumeMembru { get; set; }
        [StringLength(70)]
        public string? Adresa { get; set; }

        public string Email { get; set; }
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([09]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123'")] 
        public string? Telefon { get; set; }

        public ICollection<Participare>? Participari { get; set; }
    }
}
