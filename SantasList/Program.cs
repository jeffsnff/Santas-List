using System;

namespace SantasList
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Person> SantaList = new List<Person>();
      string command;

      while (true)
      {
        command = Greetings();

        if (command.ToLower().Equals("add"))
        {
          AddPerson(SantaList);
        }

        if (command.ToLower().Equals("print"))
        {
          PrintList(SantaList);
        }
      }
    }
    static string Greetings()
    {
      Console.WriteLine("Welcome to Santas List!");
      return Options();
    }
    static string Options()
    {
      Console.WriteLine("Enter one of the following:");
      Console.WriteLine("- 'Add' to add names to list");
      Console.WriteLine("- 'Update' to update a name in list");
      Console.WriteLine("- 'Print' to view all names in list");
      Console.Write("Command Entry : ");
      return Console.ReadLine();
    }
    static void AddPerson(List<Person> SantaList)
    {
      string name;
      string behavior;
      string breakLoop = "end";
      while (true)
      {
        Console.Write("Enter Name : ");
        name = Console.ReadLine();

        if (name.ToLower() == breakLoop)
        {
          break;
        }

        Console.Write("Enter 'Naughty' or 'Nice' : ");
        behavior = Console.ReadLine();
        while (!behavior.ToLower().Equals("naughty") && !behavior.ToLower().Equals("nice"))
        {
          Console.WriteLine("Behavior must be 'Naughty' or 'Nice'");
          behavior = Console.ReadLine();
        }
        // Add Person to SantaList
        SantaList.Add(new Person(name, behavior));
      }
    }
    static void PrintList(List<Person> SantaList)
    {
      Console.WriteLine("####################################Santas List####################################");
      Console.WriteLine("");
      foreach (Person person in SantaList)
      {
        Console.WriteLine(person+"\r\n");
      }
      Console.WriteLine("###################################################################################");
      Console.WriteLine("");
      Console.WriteLine("");
    }
  }
}