import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";
import { ContaPoupanca } from "./ContaPoupanca.js";
import { Conta } from "./Conta.js";

//ContaCorrente
const cli = new Cliente("Ricardo",111222333309);
const contaCorrente = new ContaCorrente(cli,1005);

//ContaPoupaça
const contaPoupanca = new ContaPoupanca(0,cli,1004);

console.log(contaCorrente);
console.log(contaPoupanca);
