// Write your Javascript code.

function CompararValores(idAtributo) {
    var campoValor = document.getElementById("Atributos_" + idAtributo + "__Valor");
    var campoValorEnTrama = document.getElementById("Atributos_" + idAtributo + "__ValorEnTrama");

    var valor = campoValor.value;
    var valorEnTrama = campoValorEnTrama.value;

    if (valor == valorEnTrama) {
        campoValorEnTrama.style.backgroundColor = campoValor.style.backgroundColor;
    }
    else {
        campoValorEnTrama.style.backgroundColor = 'yellow';
    }
};

function IgualarValores(idAtributo) {
    var campoValor = document.getElementById("Atributos_" + idAtributo + "__Valor");
    var campoValorEnTrama = document.getElementById("Atributos_" + idAtributo + "__ValorEnTrama");

    var valor = campoValor.value;
    var valorEnTrama = campoValorEnTrama.value;

    if (valor != valorEnTrama) {
        campoValorEnTrama.value = campoValor.value;
        campoValorEnTrama.style.backgroundColor = campoValor.style.backgroundColor;
    }
};
