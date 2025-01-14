using System.ComponentModel.DataAnnotations;



namespace Proiect3._0.Models
{
    public class Membru
    {
        public int ID { get; set; }
        public string? NumeMembru { get; set; }

        public string? Adresa { get; set; }

        public string Email { get; set; }

        public string? Telefon { get; set; }

        public ICollection<Participare>? Participari { get; set; }
    }
}
