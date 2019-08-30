using System.Collections.Generic;

namespace Audiorama.Models
{
    public class AudioramaDb {
        public List<Artista> Artista;
        public List<Album> Album;

        public AudioramaDb() {
            Artista = new List<Artista>();
            Album = new List<Album>();

            AddArtista();
        }

        private void AddArtista() {
            var blackSabbath = new Artista {
                Id = 1,
                Nome = "Black Sabbath",
                Pais = "UK"
            };

            blackSabbath.Albuns.Add(new Album {
                Id = 1,
                IdArtista = 1,
                Nome = "Black Sabbath",
                Ano = "1970"
            });

            blackSabbath.Albuns.Add(new Album {
                Id = 2,
                IdArtista = 1,
                Nome = "Paranoid",
                Ano = "1970"
            });

            var leafHound = new Artista {
                Id = 2,
                Nome = "Leaf Hound",
                Pais = "UK"
            };

            leafHound.Albuns.Add(new Album {
                Id = 3,
                IdArtista = 2,
                Nome = "Growers Of Mushroom",
                Ano = "1971"
            });

            var medusa = new Artista {
                Id = 3,
                Nome = "Medusa",
                Pais = "US"
            };

            medusa.Albuns.Add(new Album {
                Id = 4,
                IdArtista = 3,
                Nome = "First Step Beyond",
                Ano = "1975"
            });

            var eloy = new Artista {
                Id = 4,
                Nome = "Eloy",
                Pais = "Alemanha"
            };

            eloy.Albuns.Add(new Album {
                Id = 5,
                IdArtista = 4,
                Nome = "Inside",
                Ano = "1973"
            });

            eloy.Albuns.Add(new Album {
                Id = 6,
                IdArtista = 4,
                Nome = "Floating",
                Ano = "1974"
            });

            eloy.Albuns.Add(new Album {
                Id = 7,
                IdArtista = 4,
                Nome = "Power And The Passion",
                Ano = "1975"
            });

            var electricWizard = new Artista {
                Id = 5,
                Nome = "Electric Wizard",
                Pais = "UK"
            };

            electricWizard.Albuns.Add(new Album {
                Id = 8,
                IdArtista = 5,
                Nome = "Witchcult Today",
                Ano = "2007"
            });

            electricWizard.Albuns.Add(new Album {
                Id = 9,
                IdArtista = 5,
                Nome = "Black Masses",
                Ano = "2010"
            });

            electricWizard.Albuns.Add(new Album {
                Id = 10,
                IdArtista = 5,
                Nome = "Time To Die",
                Ano = "2014"
            });

            var coven = new Artista {
                Id = 6,
                Nome = "Coven",
                Pais = "US"
            };

            coven.Albuns.Add(new Album {
                Id = 11,
                IdArtista = 6,
                Nome = "Witchcraft Destroys Minds & Reaps Souls",
                Ano = "1969"
            });

            var uriahHeep = new Artista {
                Id = 7,
                Nome = "Uriah Heep",
                Pais = "UK"
            };

            uriahHeep.Albuns.Add(new Album {
                Id = 12,
                IdArtista = 7,
                Nome = "Very 'Eavy... Very 'Umble",
                Ano = "1970"
            });

            uriahHeep.Albuns.Add(new Album {
                Id = 13,
                IdArtista = 7,
                Nome = "Salisbury",
                Ano = "1971"
            });

            uriahHeep.Albuns.Add(new Album {
                Id = 14,
                IdArtista = 7,
                Nome = "Look At Yourself",
                Ano = "1971"
            });

            var pentagram = new Artista {
                Id = 8,
                Nome = "Pentagram",
                Pais = "US"
            };

            pentagram.Albuns.Add(new Album {
                Id = 15,
                IdArtista = 8,
                Nome = "Relentless",
                Ano = "1980"
            });

            var hawkwind = new Artista {
                Id = 9,
                Nome = "Hawkwind",
                Pais = "UK"
            };

            hawkwind.Albuns.Add(new Album {
                Id = 16,
                IdArtista = 9,
                Nome = "Space Ritual",
                Ano = "1973"
            });

            hawkwind.Albuns.Add(new Album {
                Id = 17,
                IdArtista = 9,
                Nome = "Warrior On The Edge Of Time",
                Ano = "1975"
            });

            var elonkorjuu = new Artista {
                Id = 10,
                Nome = "Elonkorjuu",
                Pais = "Finlândia"
            };

            elonkorjuu.Albuns.Add(new Album {
                Id = 18,
                IdArtista = 10,
                Nome = "Harvest Time",
                Ano = "1972"
            });

            Artista.Add(blackSabbath);
            Artista.Add(leafHound);
            Artista.Add(medusa);
            Artista.Add(eloy);
            Artista.Add(electricWizard);
            Artista.Add(coven);
            Artista.Add(uriahHeep);
            Artista.Add(pentagram);
            Artista.Add(hawkwind);
            Artista.Add(elonkorjuu);
        }
    }
}