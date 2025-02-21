using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Proiect3._0.Models
{
    public class Spectacol
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[a-zA-Z][a-zA-Z]*)*(\s\d+)?$", ErrorMessage =
 "Titlul spectacolului trebuie sa inceapa cu majuscula, iar restul cuvintelor pot incepe cu litera mare sau mica. Poate contine spatii si numere separate (ex. Opera 123, Opera nationala 2024, Teatrul de vara 2025)")]

        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Titlul spectacolului")]

        public string Titlu { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Data Spectacolului")]
        public DateTime DataSpectacol { get; set; }
        public int? LocatiaID { get; set; }

        public Locatia? Locatia { get; set; }
        
        public int? RegizorID { get; set; }
       
        public Regizor? Regizor { get; set; }
        
        public int? TipID { get; set; }
        public Tip? Tip { get; set; }

        public ICollection<Participare>? Participari { get; set; }
    }
}
