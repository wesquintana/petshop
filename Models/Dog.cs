using System;
namespace csharp_petshop.Models
{
  public class Dog : Animal
  {
    public Dog(string name)
    {
      Name = name;
      Sound = "BARK BARK";
    }

  }
}