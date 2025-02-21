using System.ComponentModel.DataAnnotations;

namespace Proiect3._0.Models
{
    public class Locatia
    {
        public int ID { get; set; }
        [RegularExpression(@"^([A-Z][a-zA-Z]*)(\s[A-Z][a-zA-Z]*)*(\s\d+)?$", ErrorMessage =
 "Denumirea locatiei trebuie sa inceapa fiecare cuvant cu majuscula si poate contine spatii si numere separate (ex. Opera 123 sau Opera Nationala 2024)")]



        [StringLength(30, MinimumLength = 3)]
        public string DenumireLocatie { get; set; }
        public ICollection<Spectacol>? Spectacole { get; set; }
    }
}
