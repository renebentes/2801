using System;

Console.Clear();

var dateTime = new DateTime();
// structs não são nulos 01/01/0001 00:00:00
Console.WriteLine(dateTime);

dateTime = DateTime.Now;
Console.WriteLine(dateTime);