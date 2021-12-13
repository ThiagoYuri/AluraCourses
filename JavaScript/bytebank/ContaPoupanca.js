export class ContaPoupanca{



    constructor(saldoInicial,cliente,agencia){
        this._saldo = saldoInicial;
        this._cliente = cliente;
        this._agencia = agencia;
    }
    
    sacar (valor){
        if(this._saldo>= valor )
        this._saldo = this._saldo-valor;        
    }

    depositar(valor){
        if(valor > 0 )
        this._saldo +=valor;
    }

    transferir(valor,conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }

}