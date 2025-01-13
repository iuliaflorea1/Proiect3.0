namespace Proiect3._0.Models
{
    public class CategorieSpectacol
    {
        public int ID { get; set; }

        public int SpectacolID { get; set; }

        public Spectacol Spectacol { get; set; }

        public int TipID { get; set; }

        public Tip Tip { get; set; }
    }
}
