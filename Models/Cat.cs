using System;
namespace csharp_petshop.Models
{
  public class Cat : Animal
  {
    public Cat(string name, int numWhiskers)
    {
      Name = name;
      Sound = "MEOW";
      NumWhiskers = numWhiskers;
    }
    private int NumWhiskers { get; set; }
  }

}