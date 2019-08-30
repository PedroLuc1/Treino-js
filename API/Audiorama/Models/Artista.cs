using System.Collections.Generic;

namespace Audiorama.Models
{
    public class Artista {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }

        public List<Album> Albuns { get; set; }

        public Artista() {
            Albuns = new List<Album>();
        }
    }
}