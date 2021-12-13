import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";



//Corrente1
const contaCorrenteRicarto = new ContaCorrente();
contaCorrenteRicarto.agencia =1001;
contaCorrenteRicarto.depositar(200)
contaCorrenteRicarto.sacar(17);
contaCorrenteRicarto.cliente = new Cliente();
contaCorrenteRicarto.cliente.nome = "Ricardo";
contaCorrenteRicarto.cliente.cpf = 111222333309;
//Corrente2
const contaCorrenteAlice = new ContaCorrente();
contaCorrenteAlice.agencia =1003;
contaCorrenteAlice.depositar(500)
contaCorrenteAlice.sacar(17);
contaCorrenteAlice.cliente = new Cliente();
contaCorrenteAlice.cliente.nome = "Alice"
contaCorrenteAlice.cliente.cpf = 888222333309;

contaCorrenteAlice.transferir(200,contaCorrenteRicarto)
console.log(contaCorrenteAlice);