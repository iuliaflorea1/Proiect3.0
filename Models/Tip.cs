namespace Proiect3._0.Models
{
    public class Tip
    {
        public int ID { get; set; }

        public string DenumireTip { get; set; }

        public ICollection<CategorieSpectacol>? CategorieSpectacole { get; set; }
    }
}
