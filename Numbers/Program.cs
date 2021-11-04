using System.Globalization;

Console.Clear();

// 1ª opção para moeda (precisão), a menos que precise de performance (double ou float)
decimal valor = 10536.25m;

// G - formatação padrão de números
// C - currency, moeda
// E - notação científica
// N - separador de milhar
// P - porcentagem
Console.WriteLine(
    valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

Console.WriteLine(Math.Round(valor));
Console.WriteLine(Math.Ceiling(valor));
Console.WriteLine(Math.Floor(valor));