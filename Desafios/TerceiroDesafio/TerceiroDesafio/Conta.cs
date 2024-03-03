// 1. Modelar uma classe Conta, que tenha como atributos
// uma classe Titular, além de informações da conta,
// como agência, número da conta, saldo e limite, bem
// como um método que devolva as informações da
// conta de forma detalhada.
class Conta
{
    private int numeroConta;
    private int agenciaConta;
    private double limiteConta;
    private double saldoConta;

    public TitularConta TitularConta { get; set; }
    public int NumeroConta
    {
        get { return numeroConta; }
        set { numeroConta = value; }
    }
    public int AgenciaConta
    {
        get { return agenciaConta; }
        set { agenciaConta = value; }
    }
    public double SaldoConta
    {
        get { return saldoConta; }
        set { saldoConta = value; }
    }
    public double LimiteConta
    {
        get { return limiteConta; }
        set { limiteConta = value; }
    }
    public string DetalheConta =>
        $"Conta: {NumeroConta}\nAgência: {AgenciaConta}\nTitular: {TitularConta.NomeTitularConta}\nSaldo: R${SaldoConta}\nLimite dísponivel: R${LimiteConta}";
}