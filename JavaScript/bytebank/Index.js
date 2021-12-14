import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";
import { ContaPoupanca } from "./ContaPoupanca.js";
import { Conta } from "./Conta.js";
import { ContaSalario } from "./ContaSalario.js";

//ContaCorrente
const cli = new Cliente("Ricardo",111222333309);
const contaCorrente = new ContaCorrente(cli,1005);
contaCorrente.depositar(500);
contaCorrente.sacar(100);
//ContaPoupaça
const contaPoupanca = new ContaSalario(cli);
contaPoupanca.depositar(500);
contaPoupanca.sacar(100);

console.log(contaCorrente);
console.log(contaPoupanca);
