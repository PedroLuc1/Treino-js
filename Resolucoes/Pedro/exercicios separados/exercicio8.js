

function lerObjetoProfessor() {
    var nome = document.getElementById("txtnome").value;
    var professor = {
        nome:nome
    }
   
    return professor;
}
//Abaixo exercício 8

function removerLista(){
    var lista = document.getElementById("list-professor");
    
        lista.textContent = "";
}


