namespace Proiect3._0.Models
{
    public class Regizor
    {
        public int ID { get; set; }
        public string NumeRegizor { get; set; }
        public ICollection<Spectacol>? Spectacole { get; set; }
    }
}
