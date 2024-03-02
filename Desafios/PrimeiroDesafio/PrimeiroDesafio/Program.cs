// 1. Criar uma classe que representa uma conta bancária, com
// um número indicador, titular, saldo e senha.
ContaBancaria Conta1 = new ContaBancaria();

// 2. Criar um objeto do tipo Conta, adicionar dados e mostrar as
// informações titular e saldo no console, utilizando
// interpolação de strings.
Conta1.TitularConta = "Jean Lucas Rios";
Conta1.SaldoConta = 14.478;

// 3. Desenvolver um método da classe Conta que exibe suas
// informações.
Conta1.ExibirDados();

// 4. Desenvolver uma classe que modele um carro, e que
// contenha os métodos acelerar, frear e buzinar
Carro Carro1 = new Carro();
Carro1.ModeloCarro = "Sandero";
Carro1.AnoCarro = 2015;
Carro1.CorCarro = "Vermelho";
Carro1.BuzinarCarro();

Carro Carro2 = new Carro();
Carro2.ModeloCarro = "Siena";
Carro2.AnoCarro = 2022;
Carro2.CorCarro = "Preto";
Carro2.AcelerarCarro();

Carro Carro3 = new Carro();
Carro3.ModeloCarro = "Tucson";
Carro3.AnoCarro = 2018;
Carro3.CorCarro = "Prata";
Carro3.FrearCarro();