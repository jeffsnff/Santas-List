using System;

namespace SantasList{
  internal class Program{
    static void Main(string[] args){
      List<Person> SantaList = new List<Person>();
      string command;
      string name;
      string behavior;
      string deliveredStatus;

      command = Greetings();

      


      
    }

    static string Greetings(){
      Console.WriteLine("Welcome to Santas List!");
      Console.WriteLine("Enter one of the following:");
      Console.WriteLine("- 'Add' to add names to list");
      Console.WriteLine("- 'Update' to update a name in list");
      Console.WriteLine("- 'View All' to view all names in list");
      Console.Write("Command Entry : ");

      return Console.ReadLine();

    }



  }
}