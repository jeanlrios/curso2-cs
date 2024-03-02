// 4. Desenvolver uma classe que modele um carro, e que
// contenha os métodos acelerar, frear e buzinar
class Carro
{
    public string ModeloCarro;
    public int AnoCarro;
    public string CorCarro;

    public void AcelerarCarro()
    {
        Console.WriteLine($"O carro {ModeloCarro} {CorCarro}, ano {AnoCarro} está acelerando!");
    }

    public void FrearCarro()
    {
        Console.WriteLine($"O carro {ModeloCarro} {CorCarro}, ano {AnoCarro} está freando!");
    }

    public void BuzinarCarro()
    {
        Console.WriteLine($"O carro {ModeloCarro} {CorCarro}, ano {AnoCarro} está buzinando!");
    }
}