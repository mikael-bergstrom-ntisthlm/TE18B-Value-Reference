using System;

namespace ValueReference
{
  class Program
  {
    static void Main(string[] args)
    {
      int t = 40;

      int u = t;

      PowerUp fungus = new PowerUp();

      fungus.name = "Fungi";

      fungus = new PowerUp();

      PowerUp fungus2 = fungus;

      fungus2.name = "Mana potion";

      //Modify(fungus);

      System.Console.WriteLine(fungus.name);
      
      Console.ReadLine();
    }

    static void Modify(PowerUp p)
    {
      p.name = "E-container";
    }


    // static void Modify(int u)
    // {
    //   u += 10;
    // }


  }
}
