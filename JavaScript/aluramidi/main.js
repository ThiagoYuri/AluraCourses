function tocaSom(idElementAudio){
    const element = document.querySelector(idElementAudio);

    if(element != null && element.localName === 'audio'){
        element.play()
    }else{
        console.log("Som não encontrado")
    }

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

    tecla.onkeydown = function(event){
        if(event.code == 'Space' || event.code == 'Enter'){
            tecla.classList.add('ativa');
        }
    }
    tecla.onkeyup = function(){
        tecla.classList.remove('ativa');
    }
}