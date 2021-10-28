using System;

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

Console.WriteLine(string.Format("{0:yyyy-MM-dd hh:mm:ss ff z}", dateTime));