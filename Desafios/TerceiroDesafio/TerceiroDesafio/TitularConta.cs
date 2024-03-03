// 1. Modelar uma classe Conta, que tenha como atributos
// uma classe Titular, além de informações da conta,
// como agência, número da conta, saldo e limite, bem
// como um método que devolva as informações da
// conta de forma detalhada.
class TitularConta
{
    private string nomeTitularConta;
    private string enderecoTitularConta;
    private int idTitularConta;

    public string NomeTitularConta {
        get { return nomeTitularConta; }
        set {  nomeTitularConta = value;}
    }
    public string EnderecoTitularConta
    {
        get { return enderecoTitularConta; }
        set { enderecoTitularConta = value; }
    }
    public int IdTitularConta
    {
        get { return idTitularConta; }
        set { idTitularConta = value; }
    }
}