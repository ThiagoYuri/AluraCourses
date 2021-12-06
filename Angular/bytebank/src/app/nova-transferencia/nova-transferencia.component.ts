import { Component, EventEmitter, Output } from "@angular/core";
//import { EventEmitter } from "stream";

@Component({
    selector:'app-nova-transferencia',
    templateUrl:'./nova-transferencia.component.html',
    styleUrls:['./nova-transferencia.component.scss']
})

export class NovaTransferenciaComponent{

    @Output() aoTransferir =new EventEmitter<any>();

    valor:number;
    destino:number;

    transferir(){
           console.log("Solicitada nova transfência");
           this.aoTransferir.emit({valor:this.valor ,destino:this.destino});
           //console.log("Valor: "+this.valor);
           //console.log("Valor: "+this.destino);
            this.limparCampos();
    }


    limparCampos(){
        this.valor = 0;
        this.destino = 0;
    }
}