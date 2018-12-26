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
      s = "\n" + s.PadLeft(20, '-') + "\n";

      p3_9_1();

      Console.WriteLine(s);
      do
      {
        Console.WriteLine("Введите номер главы:");
        request = Console.ReadLine().ToLower();
        request = request.Replace(".", "");
        request = request.Replace(",", "");
        Console.WriteLine(s);
        switch (request)
        {
          case "help":
          case "h":
            Help();
            break;
          case "196":
            p1_9_6();
            break;
          case "311":
            p3_1_1();
            break;
          case "312":
            p3_1_2();
            break;
          case "334":
            p3_3_4();
            break;
          case "335":
            p3_3_5();
            break;
          case "371":
            p3_7_1();
            break;
          case "372":
            p3_7_2();
            break;
          case "373":
            p3_7_3();
            break;
          case "380":
            p3_8_0();
            break;
          case "391":
            p3_9_1();
            break;
        }
        Console.WriteLine(s);
      }
      while (request != "q" && request != "qout");
    }

    static void Help()
    {
      Console.WriteLine("q или qout - Выход");
      Console.WriteLine("1.9.6 - Типы данных");
      Console.WriteLine("3.1.1 - Hello, world!");
      Console.WriteLine("3.1.2 - Форматы чисел!");
      Console.WriteLine("3.3.4 - Члены типов данных");
      Console.WriteLine("3.3.5 - Работа со строками");
      Console.WriteLine("3.7.1 - Цикл for");
      Console.WriteLine("3.7.2 - Цикл foreach");
      Console.WriteLine("3.7.3 - Цикл while");
      Console.WriteLine("3.8.0 - Операторы if и switch");
      Console.WriteLine("3.9.1 - Одномерные массивы");
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
      Console.WriteLine("h.Length = {0}", h.Length);
      Console.WriteLine("h.Contains(\"e\") = {0}", h.Contains("e"));
      Console.WriteLine("h.ToUpper() = {0}", h.ToUpper());
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.ToLower() = {0}", h.ToLower());
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.Replace(\"lo\",\"\")", h.Replace("lo", ""));
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.Insert(3,\"*\") = {0}", h.Insert(3, "*"));
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.Remove(3,\"*\") = {0}", h.Remove(3));
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.PadLeft(10,'+') = {0}", h.PadLeft(10, '+'));
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.PadRight(10,'+') = {0}", h.PadRight(10, '+'));
      Console.WriteLine("h = {0}", h);
      h = " Hello ";
      Console.WriteLine("h = {0}", h);
      Console.WriteLine("h.Trim() = {0}", h.Trim());
      Console.WriteLine("h = {0}", h);
    }

    static void p3_7_1()
    {
      for (int i = 0; i < 9; i++)
      {
        Console.Write("{0}", i);
      }
    }

    static void p3_7_2()
    {
      int[] digits = { 1, 2, 3, 4 };
      foreach (int i in digits)
      {
        Console.WriteLine(i);
      }
    }

    static void p3_7_3()
    {
      Console.WriteLine("while (i++ < 10)");
      int i = 0;
      while (i++ < 10)
      {
        Console.Write("{0}", i);
      }

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("while (i < 10)");
      i = 0;
      while (i < 10)
      {
        Console.Write("{0}", i);
        i++;
      }

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("do .. while (i++ < 10)");
      i = 1;
      do
      {
        Console.Write(i);
      }
      while (i++ < 10);
    }

    static void p3_8_0()
    {
      int page = 0;
      int price = 99;

      Console.WriteLine("Введите номер страницы:");
      page = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("if");
      Console.WriteLine();

      if (page == 1)
      {
        Console.WriteLine("Первая страница");
      }
      else
      {
        Console.WriteLine("Страница: {0}", page);
      }

      if (page == 1 && price < 100)
        Console.WriteLine("Дешевые продукты на первой странице");

      Console.WriteLine();
      Console.WriteLine("switch");
      Console.WriteLine();

      switch (page)
      {
        case 1:
          Console.WriteLine("Первая страница");
          break;
        case 2:
          Console.WriteLine("Вторая страница");
          break;
        case 3:
          Console.WriteLine("Третья страница");
          break;
        case 4:
          Console.WriteLine("Четвертая страница");
          break;
        case 5:
          Console.WriteLine("Пятая страница");
          break;
        default:
          Console.WriteLine("Страница: {0}", page);
          break;
      }
    }

    static void p3_9_1()
    {
      var arr1 = new[] { 1, 2, 3 };
      Console.WriteLine("Тип массива arr1 ( 1, 2, 3 ) - {0}", arr1.GetType());
      Console.WriteLine();

      int[] ints = { 1, 2, 3, 4, 5 };
      for (int i = 0; i < ints.Length; i++)
        Console.WriteLine(ints[i]);
    }
  }
}
