using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Osztok
{
  class Program
  {
    static int OsztokSzama(int x)
    {
      int darab;

      if (x == 0)
      {
        darab = 0;
      }
      else if (x == 1)
      {
        darab = 1;
      }
      else
      {
        darab = 2; // 1 és önmaga
        for (int i = 2; i <= Math.Sqrt((double) x); i++)
        {
          if (x % i == 0)
          {
            darab++;
          }
        }
      }

      return darab;
    }

    static bool Prim(int x)
    {
      bool igaz = false;

      if (x > 1)
      {
        if (OsztokSzama(x) == 2)
        {
          igaz = true;
        }
      }

      return igaz;
    }

    static void Main(string[] args)
    {
      // Console.WriteLine(int.MaxValue);
      Console.WriteLine("Kérek egy egész számot:");
      int szam = Convert.ToInt32(Console.ReadLine());

      #region Előző feladatok
      //Console.WriteLine("A szám osztóinak száma: {0}",
      //  OsztokSzama(szam));

      //Console.WriteLine("Prímszámok: ");
      //for (int i = 0; i <= 1000; i++)
      //{
      //  if (Prim(i))
      //  {
      //    Console.WriteLine(i);
      //  }
      //} 
      #endregion

      #region Hány darab prím
      //int darab = 0;
      //for (int i = 0; i <= szam; i++)
      //{
      //  if (Prim(i))
      //  {
      //    darab++;
      //  }
      //}
      //Console.WriteLine("{0} darab prímszám van.",darab); 
      #endregion

      StreamWriter ki = new StreamWriter("primszamok.txt");

      for (int i = 0; i <= szam; i++)
      {
        if (Prim(i))
        {
          ki.WriteLine(i);
        }
      }

      ki.Close();
      Console.WriteLine("Kiírás kész!");

      Console.ReadKey();
    }
  }
}
