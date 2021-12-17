import { Diretor } from "./Funcionario/Diretor.js";
import {Gerente} from "./Funcionario/Gerente.js";
import {SistemaAutenticacao} from "./SistemaAutenticacao.js";

const diretor = new Diretor("Rodrigo", 10000, 12345678900);
diretor.cadastrarSenha("123456")
const gerente = new Gerente("Ricardo", 5000, 12345678901);
gerente.cadastrarSenha("123")

const estaLogado = SistemaAutenticacao.login(gerente,"123");

console.log(estaLogado);