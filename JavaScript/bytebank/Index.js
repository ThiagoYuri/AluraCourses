import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";


const cliente1 = new Cliente();
const cliente2 = new Cliente();

cliente1.nome = "Ricardo";
cliente1.cpf = 111222333309;

cliente2.nome = "Alice"
cliente2.cpf = 888222333309;


const contaCorrenteRicarto = new ContaCorrente();
contaCorrenteRicarto.agencia =1001;

contaCorrenteRicarto.depositar(200)
console.log(contaCorrenteRicarto.saldo());
contaCorrenteRicarto.sacar(17);
console.log(contaCorrenteRicarto.saldo());


console.log(cliente1,cliente2);