using System;
namespace csharp_petshop.Models
{
  public class Animal
  {
    public Animal()
    {

    }
    public Animal(string name)
    {
      Name = name;
    }
    public string Name { get; set; }
    public string Sound { get; set; }
    public void makeSound()
    {
      Console.WriteLine(Sound);
    }
  }
}