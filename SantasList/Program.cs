using System;

namespace SantasList{
  internal class Program{
    static void Main(string[] args){
      List<Person> SantaList = new List<Person>();
      string command;


      command = Greetings();

      if(command.ToLower().Equals("add")){
        AddPerson();
      }
    }

    static string Greetings(){
      Console.WriteLine("Welcome to Santas List!");
      return Options();
    }

    static string Options(){
      Console.WriteLine("Enter one of the following:");
      Console.WriteLine("- 'Add' to add names to list");
      Console.WriteLine("- 'Update' to update a name in list");
      Console.WriteLine("- 'View All' to view all names in list");
      Console.Write("Command Entry : ");
      return Console.ReadLine();
    }

    static void AddPerson(){
      string name;
      string behavior;
      while(true){
        Console.Write("Enter Name : ");
        name = Console.ReadLine();
        
        // Stuck in a loop
        Console.Write("Enter 'Naughty' or 'Nice' : ");
        behavior = Console.ReadLine();
        while(!behavior.ToLower().Equals("naughty") || !behavior.ToLower().Equals("nice")){
          Console.WriteLine("Behavior must be 'Naughty' or 'Nice'");
          behavior = Console.ReadLine();
        }

      }
    }
  }
}