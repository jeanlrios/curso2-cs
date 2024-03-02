// 1. Reescrever a classe Conta, criada no ultimo desafio,
// utilizando properties.
class ContaBancaria
{
    public int IdConta { get; set; }
    public string TitularConta { get; set; }
    public double SaldoConta { get; set; }
    public int SenhaConta { get; set; }
    public string DadosConta =>
        $"Seja bem vindo, {TitularConta}.\nSeu saldo disponivel é de R${SaldoConta}\n";
}

