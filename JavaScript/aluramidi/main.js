function tocaSom(idElementAudio){
    document.querySelector(idElementAudio).play();
}



const listaDeTeclas = document.querySelectorAll('.tecla');

let contador =0;
//enquanto
while(contador < listaDeTeclas.length){
    const tecla = listaDeTeclas[contador];

    var instrumento = listaDeTeclas[contador].classList[1];

    const idAudio = `#som_${instrumento}`;
    tecla.onclick = function(){
        tocaSom(idAudio);
    }
    contador = contador +1;
}