﻿using System;
using System.Threading;

Menu();

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado!");
    Thread.Sleep(2500);
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundos");
    Console.WriteLine("M - Segundos");
    Console.WriteLine("X - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
}
