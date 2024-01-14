using System;
using System.Threading;

namespace StopWatch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Selecione uma das opções abaixo:");
      Console.WriteLine("S = Segundo(s) => 10s = 10 Segundos");
      Console.WriteLine("M = Minuto(s) => 10m = 10 Minutos");
      Console.WriteLine("0 = Sair");

      string response = Console.ReadLine().ToLower();

      char type = char.Parse(response.Substring(response.Length - 1, 1));
      string timeSubs = response.Substring(0, response.Length - 1);
      bool isANumberValid = int.TryParse(timeSubs, out _);

      if (!isANumberValid)
      {
        Console.WriteLine("O número informado não é válido.");
        Thread.Sleep(2500);
        Menu();
      }

      int time = int.Parse(timeSubs);
      int multiplier = 1;

      if (type == 'm')
        multiplier = 60;

      if (time == 0)
        Environment.Exit(0);

      PreStart(time * multiplier);

    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go...");
      Thread.Sleep(1000);
      
      Start(time);
    }
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
      Console.WriteLine("StopWatch finalizado!");
      Thread.Sleep(2500);
      Menu();
    }
  }
}