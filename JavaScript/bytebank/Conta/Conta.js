//Conta e uma classe abstrata

export class Conta{    
    constructor(saldoInicial,cliente,agencia){
        if(this.constructor == Conta){
            throw new Error("Você não pode instanciar a classe Conta, pois ela e abstrata")
        }
        this._saldo = saldoInicial;
        this._cliente = cliente;
        this._agencia = agencia;
    }


    set cliente(novoValor){
        if(novoValor instanceof Cliente){
            this._cliente = novoValor;
        }
    }
    get cliente(){
        return this._cliente;
    }

    //metodo abstrato
    sacar (valor){ 
        throw new Error("O método sacar da conta é abstrato")
    }

    _sacar (valor,taxa){       
        const valorSacado = taxa *valor;
        if(this._saldo>= valorSacado ){
            this._saldo -= valorSacado;        
            return valorSacado;
        }
    }

    depositar(valor){
        if(valor > 0 )
        this._saldo +=valor;
    }

    get saldo(){
        return this._saldo;
    }

    transferir(valor,conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }
}