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

			console.log(artista);
		}
	};

	http.send();
}

//getArtistas();
getArtista(1);