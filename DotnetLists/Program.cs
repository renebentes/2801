Console.Clear();

var arr = new int[3] { 1, 2, 3 };

try
{
    for (int i = 0; i < 10; i++)
    {
        // IndexOutOfRangeException
        Console.WriteLine(arr[i]);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado!");
}
