// 1. Reescrever a classe Conta, criada no ultimo desafio,
// utilizando properties.
ContaBancaria Conta1 = new ContaBancaria();
Conta1.IdConta = 123;
Conta1.TitularConta = "Jean Lucas Rios";
Conta1.SaldoConta = 29.566;
Console.WriteLine(Conta1.DadosConta);

// 2. Reescrever os atributos da classe Carro, de modo que
// eles sejam properties, e adicionar uma nova
// propertie DescricaoDetalhada, que mostra o
// fabricante, modelo e ano do carro.
Carro Carro1 = new Carro();
Carro1.ModeloCarro = "Palio";
Carro1.FabricanteCarro = "FIAT";
Carro1.Ano = 2010;
Carro1.CorCarro = "Prata";
Console.WriteLine(Carro1.DescricaoDetalhada);
Console.WriteLine("");

Carro Carro2 = new Carro();
Carro2.ModeloCarro = "GOL";
Carro2.FabricanteCarro = "Volkswagen";
Carro2.Ano = 2023;
Carro2.CorCarro = "Vermelho";
Console.WriteLine(Carro2.DescricaoDetalhada);
Console.WriteLine("");

Carro Carro3 = new Carro();
Carro3.ModeloCarro = "Mobi";
Carro3.FabricanteCarro = "FIAT";
Carro3.Ano = 2024;
Carro3.CorCarro = "Amarelo";
Console.WriteLine(Carro3.DescricaoDetalhada);
Console.WriteLine("");

Carro Carro4 = new Carro();
Carro4.ModeloCarro = "Fusca";
Carro4.FabricanteCarro = "Volkswagen";
Carro4.Ano = 1959;
Carro4.CorCarro = "Branco";
Console.WriteLine(Carro4.DescricaoDetalhada);
Console.WriteLine("");


// 4. Desenvolver a classe Produto, com os atributos
// nome, marca, preco e estoque. Além disso, garantir
// que o preço e o estoque do produto sejam valores
// positivos e criar uma propriedade que mostra detalhadamente
// as informações do produto, para que seja usado pela equipe de vendas.
Produto produto1 = new Produto();
produto1.nome = "Leite em Pó 200g";
produto1.marca = "ITALAC";
produto1.PrecoDisponivel = 0;
produto1.Quantidade= 23;
Console.WriteLine(produto1.InfoProduto); 
Produto produto2 = new Produto();
produto2.nome = "Sal Refinado 1kg";
produto2.marca = "CISNE";
produto2.PrecoDisponivel = 14.90;
produto2.Quantidade = -1;
Console.WriteLine(produto2.InfoProduto);