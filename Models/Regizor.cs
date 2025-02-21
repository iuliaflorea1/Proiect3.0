using System.ComponentModel.DataAnnotations;

namespace Proiect3._0.Models
{
    public class Regizor
    {
        public int ID { get; set; }
        [RegularExpression(@"^([A-Z][a-zA-Z]*)+( [A-Z][a-zA-Z]*)*$", ErrorMessage =
"Numele regizorului trebuie sa inceapa fiecare cuvant cu majuscula (ex. Ana sau Ana Maria sau AnaMaria)")]


        [StringLength(30, MinimumLength = 3)]
        public string NumeRegizor { get; set; }
        public ICollection<Spectacol>? Spectacole { get; set; }
    }
}
