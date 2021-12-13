import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";



//Corrente1
const contaCorrenteRicarto = new ContaCorrente();
contaCorrenteRicarto.agencia =1001;
contaCorrenteRicarto.depositar(200)
contaCorrenteRicarto.sacar(17);
const cli1 = new Cliente();
cli1.nome = "Ricardo";
cli1.cpf = 111222333309;
contaCorrenteRicarto.cliente = (cli1);

//Corrente2
const contaCorrenteAlice = new ContaCorrente();
contaCorrenteAlice.agencia =1003;
contaCorrenteAlice.depositar(500)
contaCorrenteAlice.sacar(17);
const cli2 = new Cliente();
cli2.nome = "Alice";
cli2.cpf = 111222209;
contaCorrenteAlice.cliente=(cli2);

contaCorrenteAlice.transferir(200,contaCorrenteRicarto)
console.log(contaCorrenteAlice);
console.log(contaCorrenteAlice.saldo);