using System;
using System.Linq;
using Audiorama.Models;
using Microsoft.AspNetCore.Mvc;

namespace Audiorama.Controllers {
    [Route("api/artistas")]
    public class ArtistasController : ControllerBase {
        private readonly AudioramaDb _db;

        public ArtistasController(AudioramaDb db) {
            _db = db;
        }

        [HttpGet]
        public IActionResult Obter() {
            return Ok(_db.Artista);
        }

        [HttpGet("{id:long:min(1)}")]
        public IActionResult Obter(long id) {
            var artista = _db.Artista.FirstOrDefault(_ => _.Id == id);

            if (artista == null)
                throw new ArgumentNullException("Artista não encontrado");

            return Ok(artista);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Artista artista) {
            artista.Id = new Random().Next();
            _db.Artista.Add(artista);

            return Ok(artista);
        }

        [HttpPut("{id:long:min(1)}")]
        public IActionResult Atualizar(long id, [FromBody] Artista artista) {
            var _artista = _db.Artista.FirstOrDefault(_ => _.Id == id);

            if (_artista == null)
                throw new ArgumentNullException("Artista não encontrado");

            _artista.Nome = artista.Nome;
            _artista.Pais = artista.Pais;

            return Ok(_artista);
        }

        [HttpDelete("{id:long:min(1)}")]
        public IActionResult Desativar(long id) {
            var artista = _db.Artista.FirstOrDefault(_ => _.Id == id);

            if (artista == null)
                throw new ArgumentNullException("Artista não encontrado");

            _db.Artista.Remove(artista);

            return NoContent();
        }

        [HttpPost("{id:long:min(1)}/albuns")]
        public IActionResult AdicionarAlbum(long id, [FromBody] Album album) {
            var artista = _db.Artista.FirstOrDefault(_ => _.Id == id);

            if (artista == null)
                throw new ArgumentNullException("Artista não encontrado");

            artista.Albuns.Add(album);

            return Ok(artista);
        }
    }
}