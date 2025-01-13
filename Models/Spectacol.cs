using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Proiect3._0.Models
{
    public class Spectacol
    {
        public int ID { get; set; }
        [Display(Name = "Titlul spectacolului")]

        public string Titlu { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DataSpectacol { get; set; }
        public int? LocatiaID { get; set; }

        public Locatia? Locatia { get; set; }
        public ICollection<CategorieSpectacol>? CategorieSpectacole { get; set; }
        public int? RegizorID { get; set; }

        public Regizor? Regizor { get; set; }

    }
}
