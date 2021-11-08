﻿Console.Clear();

var arr = new int[3] { 1, 2, 3 };

try
{
    Cadastrar(null);

    for (int i = 0; i < 10; i++)
    {
        // IndexOutOfRangeException
        Console.WriteLine(arr[i]);
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o índice na lista");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Falha ao cadastrar");
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.QuandoOcorreu);
    Console.WriteLine("Falha ao cadastrar");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado!");
}
finally
{
    Console.WriteLine("Chegou ao fim");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new MinhaException(DateTime.Now);
    }
}

public class MinhaException : Exception
{
    public MinhaException(DateTime quandoOcorreu)
    {
        QuandoOcorreu = quandoOcorreu;
    }

    public DateTime QuandoOcorreu { get; set; }

}