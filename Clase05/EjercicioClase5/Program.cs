using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Program
  {
    static void Main(string[] args)
    {
      Tinta t1 = new Tinta(ConsoleColor.DarkCyan);
      Tinta t2 = new Tinta(ConsoleColor.DarkCyan);

      Console.WriteLine(Tinta.MostrarEst(t1));

      if(t1==t2)
      {
        Console.WriteLine("Son iguales.");
      }else
      {
        Console.WriteLine("Son distintos.");
      }
      
      
      Console.ReadKey();
    }
  }
}
