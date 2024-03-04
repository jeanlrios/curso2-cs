

using System.Security.Cryptography;

void OpcoesMenu()
{
    Console.WriteLine("Digite 1 para ver o Exercicio 1");
    Console.WriteLine("Digite 2 para ver o Exercicio 2");
    Console.WriteLine("Digite 3 para ver o Exercicio 3");
    Console.WriteLine("Digite 4 para ver o Exercicio 4");
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
        case 4: Exercicio4();
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
    Alunos aluno1 = new Alunos();
    aluno1.NomeAluno = "Jean Lucas";
    aluno1.IdadeAluno = 22;
    aluno1.NotasAluno = 10;
    
    Alunos aluno2 = new Alunos();
    aluno2.NomeAluno = "Jorge";
    aluno2.IdadeAluno = 23;
    aluno2.NotasAluno = 10;
    
    Alunos aluno3 = new Alunos();
    aluno3.NomeAluno = "João";
    aluno3.IdadeAluno = 20;
    aluno3.NotasAluno = 10;

    Professor professor1 = new Professor();
    professor1.NomeProfessor = "Guilherme";
    professor1.DisciplinaProfessor = "C#";
   
    Disciplina disciplina = new Disciplina();
    disciplina.AdicionarAluno(aluno1);
    disciplina.AdicionarAluno(aluno2);
    disciplina.AdicionarAluno(aluno3);
    disciplina.NomeDisciplina = "C#";
    disciplina.ExibirAlunos();

    Console.WriteLine("\nPara voltar pro Menu pressione qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    OpcoesMenu();
}

void Exercicio4()
{
    // 5. Modelar um sistema para um restaurante com classes como Restaurante,
    // Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem
    // ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos
    // podem estar associados a uma mesa.
    ProdutosRestaurante prato1 = new ProdutosRestaurante();
    prato1.NomePrato = "Strogonoff de Carne";
    prato1.PrecoPrato = 23.90;
    ProdutosRestaurante prato2 = new ProdutosRestaurante();
    prato2.NomePrato = "Lasanha de Frango";
    prato2.PrecoPrato = 25.90;
    ProdutosRestaurante prato3 = new ProdutosRestaurante();
    prato3.NomePrato = "Omelete";
    prato3.PrecoPrato = 19.90;

    ProdutosRestaurante bebida1 = new ProdutosRestaurante();
    bebida1.NomeBebida = "Coca-cola";
    bebida1.PrecoBebida = 9.90;
    ProdutosRestaurante bebida2 = new ProdutosRestaurante();
    bebida2.NomeBebida = "Fanta Laranja";
    bebida2.PrecoBebida = 8.80;
    ProdutosRestaurante bebida3 = new ProdutosRestaurante();
    bebida3.NomeBebida = "Sprite";
    bebida3.PrecoBebida = 7.80;

    Mesas mesa1 = new Mesas();
    mesa1.NumeroMesa = 01;

    Mesas mesa2 = new Mesas();
    mesa2.NumeroMesa = 02;

    Mesas mesa3 = new Mesas();
    mesa3.NumeroMesa = 03;
        
}

OpcoesMenu();




