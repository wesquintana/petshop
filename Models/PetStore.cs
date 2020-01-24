using System;
using System.Collections.Generic;

namespace csharp_petshop.Models
{
  public class PetStore
  {
    public PetStore(string name)
    {
      Name = name;
      Animals = new List<Animal>();
      Dogs = new List<Dog>();
      Cats = new List<Cat>();
    }
    public List<Animal> Animals { get; private set; }
    public List<Dog> Dogs { get; private set; }
    public List<Cat> Cats { get; private set; }
    public string Name { get; private set; }
    public void seeAnimals()
    {
      int i = 1;
      foreach (Animal animal in Animals)
      {
        Console.Write($"\n{i}. {animal.GetType().Name} {animal.Name}");
        i++;
      }
    }
    public void seeDogs()
    {
      int i = 1;
      Console.WriteLine("Dogs: ");
      foreach (Dog dog in Dogs)
      {
        Console.Write($"\n{i}. {dog.Name}");
        i++;
      }
    }
    public void addDog(Dog dog)
    {
      Animals.Add(dog);
      Dogs.Add(dog);
    }
    public void addCat(Cat cat)
    {
      Animals.Add(cat);
      Cats.Add(cat);
    }
  }
}