using System.ComponentModel.DataAnnotations;

namespace Proiect3._0.Models
{
    public class Participare
    {
        public int ID { get; set; }

        public int? MembruID { get; set; }
        public Membru? Membru { get; set; }

        public int? SpectacolID { get; set; }
        public Spectacol? Spectacol { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Spectacolului")]
        public DateTime DataSpectacol { get; set; }
    }
}
