

using System.Security.Cryptography;

void OpcoesMenu()
{
    Console.WriteLine("Digite 1 para ver o Exercicio 1");
    Console.WriteLine("Digite 2 para ver o Exercicio 2");
    Console.WriteLine("Digite 3 para ver o Exercicio 3");
    Console.WriteLine("");
    Console.Write("Digite a sua opção: ");
    string OpcaoEscolhida = Console.ReadLine();
    int OpcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);

    switch (OpcaoEscolhidaNumerica)
    {
        case 1: Exercicio1();
            break;
        case 2: Exercicio2();
            break;
        case 3: Exercicio3();
            break;
    }

}

void Exercicio1()
{
    // 1. Modelar uma classe Conta, que tenha como atributos
    // uma classe Titular, além de informações da conta,
    // como agência, número da conta, saldo e limite, bem
    // como um método que devolva as informações da
    // conta de forma detalhada.
    Console.Clear();
    Console.WriteLine("\nExercicio 1\n");
    TitularConta infoTitular = new TitularConta();
    infoTitular.NomeTitularConta = "Jean Lucas Rios";
    infoTitular.EnderecoTitularConta = "São Paulo, Brasil";
    infoTitular.IdTitularConta = 29304;

    Conta infoConta = new Conta();
    infoConta.TitularConta = infoTitular;
    infoConta.NumeroConta = 256;
    infoConta.AgenciaConta = 034455;
    infoConta.SaldoConta = 2.643;
    infoConta.LimiteConta = 10.525;
    Console.WriteLine(infoConta.DetalheConta);
    Console.WriteLine("\nPara voltar pro Menu pressione qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();

}

void Exercicio2()
{
    // 2. Desenvolver uma classe que represente um estoque de
    // produtos, e que tenha as funcionalidades de adicionar
    // novos produtos, e exibir todos os produtos no estoque.
    Console.Clear();
    Console.WriteLine("\nExercicio 2\n");
    Produtos produto1 = new Produtos();
    produto1.Nome = "Leite";
    produto1.Marca = "ITALAC";
    produto1.Preco = 3.60;
    produto1.Quantidade = 23;

    Produtos produto2 = new Produtos();
    produto2.Nome = "Arroz";
    produto2.Marca = "Camil";
    produto2.Preco = 11.90;
    produto2.Quantidade = 11;

    Produtos produto3 = new Produtos();
    produto3.Nome = "Feijão";
    produto3.Marca = "Broto Legal";
    produto3.Preco = 0;
    produto3.Quantidade = -55;

    Estoque estoque1 = new Estoque();
    estoque1.AdicionarProduto(produto1);
    estoque1.AdicionarProduto(produto2);
    estoque1.AdicionarProduto(produto3);
    estoque1.ExibirProdutos();
    Console.WriteLine("\nPara voltar pro Menu pressione qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}

void Exercicio3()
{
    // 3. Modelar o sistema de uma escola. Crie classes para
    // Aluno, Professor e Disciplina. A classe Aluno deve ter
    // informações como nome, idade e notas. A classe
    // Professor deve ter informações sobre nome e
    // disciplinas lecionadas. A classe Disciplina deve
    // armazenar o nome da disciplina e a lista de alunos matriculados.
    Console.Clear();
    Console.WriteLine("\nExercicio 3\n");
    Console.WriteLine("Em breve...");
    Console.WriteLine("\nPara voltar pro Menu pressione qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();

}

OpcoesMenu();




