using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Soma()
    {

      Console.Clear();
      Console.WriteLine("Primeiro valor:");
      float firstValue = float.Parse(Console.ReadLine()  ?? "0");

      Console.WriteLine("Segundo valor:");
      float secondValue = float.Parse(Console.ReadLine()  ?? "0");

      float result = firstValue + secondValue;
      Console.WriteLine($"{firstValue} + {secondValue} = " + result);

      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float firstValue = float.Parse(Console.ReadLine() ?? "0");

      Console.WriteLine("Segundo valor:");
      float secondValue = float.Parse(Console.ReadLine() ?? "0");

      float result = firstValue - secondValue;
      Console.WriteLine($"{firstValue} - {secondValue} = " + result);

      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      float firstValue = float.Parse(Console.ReadLine() ?? "0");

      Console.WriteLine("Segundo Valor");
      float secondValue = float.Parse(Console.ReadLine() ?? "0");

      float total = firstValue / secondValue;
      Console.WriteLine($"{firstValue} / {secondValue} = {total}");

      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      float? firstValue = float.Parse(Console.ReadLine() ?? "0");

      Console.WriteLine("Segundo Valor");
      float? secondValue = float.Parse(Console.ReadLine() ?? "0");

      float? total = firstValue * secondValue;
      Console.WriteLine($"{firstValue} x {secondValue} = {total}");

      Console.ReadKey();
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Selecione uma das opções abaixo:");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("------------------");

      short result = short.Parse(Console.ReadLine());

      switch (result)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 0:
          System.Environment.Exit(0);
          break;
        default:
          Menu();
          break;
      }
    }
  }

}