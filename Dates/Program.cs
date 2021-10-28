using System;
using System.Globalization;

Console.Clear();

var dateTime = new DateTime();
// structs não são nulos 01/01/0001 00:00:00
Console.WriteLine(dateTime);

dateTime = DateTime.Now;
Console.WriteLine(dateTime);

dateTime = new DateTime(2020,10,27, 21, 18, 30);
Console.WriteLine(dateTime);
Console.WriteLine(dateTime.Year);
Console.WriteLine(dateTime.Month);
Console.WriteLine(dateTime.DayOfYear);

Console.WriteLine(string.Format("{0:r}", dateTime));
Console.WriteLine(string.Format("{0:s}", dateTime));
Console.WriteLine(string.Format("{0:u}", dateTime));

// Não modifica o valor da data
Console.WriteLine(dateTime.AddDays(12));
Console.WriteLine(dateTime.AddMonths(2));
Console.WriteLine(dateTime.AddYears(-3));

dateTime = DateTime.Now;

// Structs, Value Types são comparados todos os dados
// dateTime nunca será igual a outro DateTime.Now
if (dateTime.Date == DateTime.Now.Date)
{
    Console.WriteLine("É igual");
}

var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");
var atual = CultureInfo.CurrentCulture;

Console.WriteLine(dateTime.ToString("D", pt));
Console.WriteLine(dateTime.ToString("D", br));
Console.WriteLine(dateTime.ToString("D", en));
Console.WriteLine(dateTime.ToString("D", de));

// Aplicações globalizadas, ideal é usar o tempo UTC
var dateTimeUtc = DateTime.UtcNow;
Console.WriteLine(dateTimeUtc.ToLocalTime());

var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezoneAustralia);
Console.WriteLine(horaAustralia);

var timezones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timezones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezone));
    Console.WriteLine("----------");
}

var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);

var timeSpanNanoSegundos = new TimeSpan(1);
Console.WriteLine(timeSpanNanoSegundos);

var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine(timeSpanHoraMinutoSegundo);

var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));