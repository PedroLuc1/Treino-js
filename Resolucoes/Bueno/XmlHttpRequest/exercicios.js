const API_URL = "http://localhost:5000/api";

let artistas = [];
let artista  = {};

/* Ex 1 */
function getArtistas() {
	const http = new XMLHttpRequest();

	http.open("GET", `${API_URL}/artistas`, true);

	http.onreadystatechange = () => {
		if (http.readyState === XMLHttpRequest.DONE && http.status === 200) {
			artistas = JSON.parse(http.responseText);

			console.log("---> Lista de artistas: ");
			console.log(artistas);
		}
	};

	http.send();
}

/* Ex 2 */
function getArtista(id) {
	const http = new XMLHttpRequest();

	http.open("GET", `${API_URL}/artistas/${id}`, true);

	http.onreadystatechange = () => {
		if (http.readyState === XMLHttpRequest.DONE && http.status === 200) {
			artista = JSON.parse(http.responseText);

			console.log("---> Artista por Id:");
			console.log(artista);
		}
	};

	http.send();
}

/* Ex 3 */
function createArtista(novoArtista) {
	const http = new XMLHttpRequest();

	http.open("POST", `${API_URL}/artistas`, true);
	http.setRequestHeader("Content-Type", "application/json");

	http.onreadystatechange = function() {
		if (this.readyState === XMLHttpRequest.DONE && http.status === 200) {
			artista = JSON.parse(this.responseText);

			console.log("---> Criando artista: ");
			console.log(artista);
		}
	};

	http.send(JSON.stringify(novoArtista));
}

/* Ex 4 */
function updateArtista(id, novoArtista) {
	const http = new XMLHttpRequest();

	http.open("PUT", `${API_URL}/artistas/${id}`, true);
	http.setRequestHeader("Content-Type", "application/json");

	http.onreadystatechange = () => {
		if (http.readyState === XMLHttpRequest.DONE && http.status === 200) {
			artista = JSON.parse(http.responseText);

			console.log("---> Editando o artista: ");
			console.log(artista);
		}
	};

	http.send(JSON.stringify(novoArtista));
}

/* Ex 5 */
function deleteArtista(id) {
	const http = new XMLHttpRequest();

	http.open("DELETE", `${API_URL}/artistas/${id}`, true);

	http.onreadystatechange = () => {
		if (http.readyState === XMLHttpRequest.DONE && http.status === 200) {
			console.log("Artista desativado com sucesso.");
		}
	};

	http.send();
}


getArtistas();
getArtista(1);

createArtista({ 
	nome: "Sudden Death", 
	pais: "Não lembro" 
});

updateArtista(2, { 
	nome: "Perfume Azul Do Sol", 
	pais: "Brasil" 
});

deleteArtista(1);