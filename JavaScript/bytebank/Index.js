import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";

//Corrente1

const cli1 = new Cliente("Ricardo",111222333309);
const contaCorrenteRicarto = new ContaCorrente(1500,cli1);

//Corrente2
const cli2 = new Cliente("Alice",111222209);
const contaCorrenteAlice = new ContaCorrente(1003,cli2);
contaCorrenteAlice.depositar(600);
contaCorrenteAlice.cliente=(cli2);

contaCorrenteAlice.transferir(200,contaCorrenteRicarto)
console.log(contaCorrenteAlice);
console.log(ContaCorrente.numeroDeContas);