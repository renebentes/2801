Console.Clear();

var meuArray = new Teste[2];
meuArray[0] = new Teste();

Console.WriteLine(meuArray[0].Id);
Console.WriteLine(meuArray[1]);

struct Teste
{
    public int Id { get; set; }
}