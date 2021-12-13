export class ContaCorrente{
    agencia;
    cliente;

    _saldo = 0;    

    sacar (valor){
        if(this._saldo>= valor )
        this._saldo = this._saldo-valor;        
    }

    depositar(valor){
        if(valor > 0 )
        this._saldo +=valor;
    }

    saldo(){
        return this._saldo;
    }

    transferir(valor,conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }
}