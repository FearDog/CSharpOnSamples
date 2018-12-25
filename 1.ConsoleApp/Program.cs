using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string request;
      string s = "";
      s = "\n" +s.PadLeft(20, '-') + "\n";
      do
      {
        Console.WriteLine("Введите номер главы:");
        request = Console.ReadLine().ToLower();
        Console.WriteLine(s);
        switch (request)
        {
          case "help":
          case "h":
            Help();
            break;
          case "1.9.6":
            p1_9_6();
            break;
          case "3.1.1":
            p3_1_1();
            break;
          case "3.1.2":
            p3_1_2();
            break;
          case "3.3.4":
            p3_3_4();
            break;
          case "3.3.5":
            p3_3_5();
            break;
        }
        Console.WriteLine(s);
      }
      while (request != "q" && request != "qout");

      {

      }
    }

    static void Help()
    {
      Console.WriteLine("q или qout - Выход");
      Console.WriteLine("1.9.6 - Типы данных");
      Console.WriteLine("3.1.1 - Hello, world!");
      Console.WriteLine("3.1.2 - Форматы чисел!");
      Console.WriteLine("3.3.4 - Члены типов данных");
      Console.WriteLine("3.3.5 - Работа со строками");
    }

    static void p1_9_6()
    {
      Console.WriteLine("Byte:\t" + System.Byte.MinValue + "-" + System.Byte.MaxValue);
      Console.WriteLine("SByte:\t" + System.SByte.MinValue + "-" + System.SByte.MaxValue);
      Console.WriteLine();
      Console.WriteLine("Int16:\t" + System.Int16.MinValue + "-" + System.Int16.MaxValue);
      Console.WriteLine("short:\t" + short.MinValue + "-" + short.MaxValue);
      Console.WriteLine("Int32:\t" + System.Int32.MinValue + "-" + System.Int32.MaxValue);
      Console.WriteLine("int:\t" + int.MinValue + "-" + int.MaxValue);
      Console.WriteLine("Int64:\t" + System.Int64.MinValue + "-" + System.Int64.MaxValue);
      Console.WriteLine("long:\t" + long.MinValue + "-" + long.MaxValue);
      Console.WriteLine("UInt16:\t" + System.UInt16.MinValue + "-" + System.UInt16.MaxValue);
      Console.WriteLine("ushort:\t" + ushort.MinValue + "-" + ushort.MaxValue);
      Console.WriteLine("UInt32:\t" + System.UInt32.MinValue + "-" + System.UInt32.MaxValue);
      Console.WriteLine("uuint:\t" + uint.MinValue + "-" + uint.MaxValue);
      Console.WriteLine("UInt64:\t" + System.UInt64.MinValue + "-" + System.UInt64.MaxValue);
      Console.WriteLine("long:\t" + ulong.MinValue + "-" + ulong.MaxValue);
      Console.WriteLine();
      Console.WriteLine("Single:\t" + System.Single.MinValue + "-" + System.Single.MaxValue);
      Console.WriteLine("float:\t" + float.MinValue + "-" + float.MaxValue);
      Console.WriteLine("Double:\t" + System.Double.MinValue + "-" + System.Double.MaxValue);
      Console.WriteLine("double:\t" + double.MinValue + "-" + double.MaxValue);
      Console.WriteLine();
      Console.WriteLine("Decimal:" + System.Decimal.MinValue + "-" + System.Decimal.MaxValue);
      Console.WriteLine("decimal:" + decimal.MinValue + "-" + decimal.MaxValue);
      Console.WriteLine();
      Console.WriteLine("Boolean:" + System.Boolean.FalseString + "-" + System.Boolean.TrueString);
      Console.WriteLine("bool:\t" + bool.FalseString + "-" + bool.TrueString);
      Console.WriteLine("Char:\t" + System.Char.MinValue + "-" + System.Char.MaxValue);
      Console.WriteLine("char:\t" + char.MinValue + "-" + char.MaxValue);
    }

    static void p3_1_1()
    {
      Console.WriteLine("Hello? world!");
    }

    static void p3_1_2()
    {
      Console.WriteLine("Значение 123456 в разных форматах");
      Console.WriteLine("d7: {0:d7}", 123456);
      Console.WriteLine("c: {0:c}", 123456);
      Console.WriteLine("n: {0:n}", 123456);
      Console.WriteLine("f3: {0:f3}", 123456);
    }

    static void p3_3_4()
    {
      Console.WriteLine("TrueString {0}", bool.TrueString);
      Console.WriteLine("FalseString {0}", bool.FalseString);
      Console.WriteLine("char.IsDigit('1') {0}", char.IsDigit('1'));
      Console.WriteLine("char.IsDigit('a') {0}", char.IsDigit('a'));
    }

    static void p3_3_5()
    {
      string h = "Hello";
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("Длина h = {0}", h.Length);
      Console.WriteLine("h в верхнем регистре = {0}", h.ToUpper());
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h в нижнем регистре = {0}", h.ToLower());
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h содержит e? : {0}", h.Contains("e"));
      Console.WriteLine("Замена {0}", h.Replace("lo",""));
      Console.WriteLine("h = {0}", h);
    }

  }
}
