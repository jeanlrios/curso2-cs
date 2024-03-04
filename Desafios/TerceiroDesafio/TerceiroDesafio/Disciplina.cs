// 3. Modelar o sistema de uma escola. Crie classes para
// Aluno, Professor e Disciplina. A classe Aluno deve ter
// informações como nome, idade e notas. A classe
// Professor deve ter informações sobre nome e
// disciplinas lecionadas. A classe Disciplina deve
// armazenar o nome da disciplina e a lista de alunos matriculados.
class Disciplina
{
    public string NomeDisciplina { get; set; }
    private List<Alunos> alunos { get; set; } = new List<Alunos>();
    public void AdicionarAluno(Alunos aluno)
    {
        alunos.Add(aluno);
    }

    public void ExibirAlunos()
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.NomeAluno}\nDisciplina: {NomeDisciplina}\n");
        }
    }

}