using System.ComponentModel.DataAnnotations;

namespace Proiect3._0.Models
{
    public class Tip
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string DenumireTip { get; set; }

        public ICollection<Spectacol>? Spectacole { get; set; }
    }
}
