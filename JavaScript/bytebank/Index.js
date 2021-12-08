class Cliente{
    nome;
    cpf;
}


class ContaCorrente{
    agencia;
    saldo;    

    sacar (valor){
        if(this.saldo>= valor )
        this.saldo = this.saldo-valor;        
    }
}

const cliente1 = new Cliente();
const cliente2 = new Cliente();

cliente1.nome = "Ricardo";
cliente1.cpf = 111222333309;

cliente2.nome = "Alice"
cliente2.cpf = 888222333309;


const contaCorrenteRicarto = new ContaCorrente();
contaCorrenteRicarto.saldo = 0;
contaCorrenteRicarto.agencia =1001;

console.log(contaCorrenteRicarto.saldo);
contaCorrenteRicarto.saldo = 100;
console.log(contaCorrenteRicarto.saldo);
contaCorrenteRicarto.sacar(16);
console.log(contaCorrenteRicarto.saldo);


console.log(cliente1,cliente2);