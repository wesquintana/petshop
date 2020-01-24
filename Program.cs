using System;
using csharp_petshop.Models;
namespace csharp_petshop
{
  class Program
  {
    static void Main(string[] args)
    {
      PetStore johnnys = new PetStore("Johnny's");
      johnnys.addDog(new Dog("Rolla"));
      johnnys.addCat(new Cat("Meeko", 33));
      johnnys.addDog(new Dog("Petey"));
      johnnys.addDog(new Dog("Mater"));
      johnnys.seeAnimals();
      Console.Write("\n");
      Console.ReadKey();
      johnnys.seeDogs();
    }
  }
}

