function tocaSom(idElementAudio){
    document.querySelector(idElementAudio).play();
}



const listaDeTeclas = document.querySelectorAll('.tecla');

//para
for(let contador = 0; contador < listaDeTeclas.length; contador++){
    const tecla = listaDeTeclas[contador];
    var instrumento = listaDeTeclas[contador].classList[1];
    const idAudio = `#som_${instrumento}`;
    
    tecla.onclick = function(){
        tocaSom(idAudio);
    }
}