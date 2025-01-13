namespace Proiect3._0.Models
{
    public class Locatia
    {
        public int ID { get; set; }
        public string DenumireLocatie { get; set; }
        public ICollection<Spectacol>? Spectacole { get; set; }
    }
}
