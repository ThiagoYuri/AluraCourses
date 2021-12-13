import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";
import { ContaPoupanca } from "./ContaPoupanca.js";

//ContaCorrente
const cli1 = new Cliente("Ricardo",111222333309);
const contaCorrente = new ContaCorrente(1500,cli1);

//ContaPoupaça
const cli2 = new Cliente("Kauan",32312421431);
const contaPoupanca = new ContaPoupanca(8815,cli2);

console.log(contaCorrente);
console.log(contaPoupanca);
