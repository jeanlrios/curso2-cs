class Episodio
{
    private List<string> convidados = new();
    public Episodio(int numero, string titulo, int duracaoEp)
    {
        Numero = numero;
        Titulo = titulo;
        DuracaoEp = duracaoEp;
    }

    public int Numero { get; }
    public int DuracaoEp { get; }
    public string Titulo { get; }
    public string Resumo => $"{Numero} - {Titulo} ({DuracaoEp} minutos) {string.Join(", ", convidados)}";
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}