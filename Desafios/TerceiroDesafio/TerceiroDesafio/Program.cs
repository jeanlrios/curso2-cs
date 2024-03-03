// 1. Modelar uma classe Conta, que tenha como atributos
// uma classe Titular, além de informações da conta,
// como agência, número da conta, saldo e limite, bem
// como um método que devolva as informações da
// conta de forma detalhada.
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


