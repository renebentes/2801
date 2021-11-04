Console.Clear();

var funcionarios = new Funcionario[5];
funcionarios[0] = new Funcionario { Id = 1225, Nome="Rene" };

foreach (var funcionario in funcionarios)
{
    Console.WriteLine(funcionario.Id);
    Console.WriteLine(funcionario.Nome);
}

struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}