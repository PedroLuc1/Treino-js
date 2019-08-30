namespace Audiorama.Models
{
    public class Album {
        public long Id { get; set; }
        public long IdArtista { get; set; }
        public string Nome { get; set; }
        public string Ano { get; set; }
    }
}