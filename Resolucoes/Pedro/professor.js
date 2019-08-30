

function lerObjetoProfessor() {
    var nome = document.getElementById("txtnome").value;
    var professor = {
        nome:nome
    }
   
    return professor;
}


function removerLista(){
    var lista = document.getElementById("list-professor");
    
        lista.textContent = "";
}


function listaProfessores(lista){
    var ul = document.getElementById("list-professor");
    for (var i = 0; i <= lista.length -1; i++) {
        var paragrafo = document.createElement("p");
        paragrafo.innerHTML = lista[i].nome;    
        ul.appendChild(paragrafo);
            }  
}
