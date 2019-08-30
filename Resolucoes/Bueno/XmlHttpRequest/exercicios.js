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
	}

	http.send();
}

/* Ex 2 */

getArtistas();