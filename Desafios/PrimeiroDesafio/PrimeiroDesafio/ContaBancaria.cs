// 1. Criar uma classe que representa uma conta bancária, com
// um número indicador, titular, saldo e senha.
class ContaBancaria
{
    public int IdConta;
    public string TitularConta;
    public double SaldoConta;
    public int SenhaConta;

    // 3. Desenvolver um método da classe Conta que exibe suas
    // informações.
    public void ExibirDados()
    {
        Console.WriteLine($"Bem vindo! {TitularConta}");
        Console.WriteLine($"Seu saldo é de R${SaldoConta}\n");
    }
}

