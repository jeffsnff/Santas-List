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
          string printCommand = PrintOptions();
          PrintList(SantaList, printCommand);
        }

        if (command.ToLower().Equals("update")){
          UpdateDeliveredStatus(SantaList);
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
    static void PrintList(List<Person> SantaList, string printCommand)
    {
      Console.WriteLine("####################################Santas List####################################");
      Console.WriteLine("");
      foreach (Person person in SantaList)
      {
        if(printCommand.Equals("all")){
          Console.WriteLine(person + "\r\n");
        }
        if(printCommand.Equals("nice")){
          if(person.behavior.ToLower().Equals("nice")){
            Console.WriteLine(person+"\r\n");
          }
        }
        if(printCommand.Equals("naughty")){
          if(person.behavior.ToLower().Equals("naughty")){
            Console.WriteLine(person+"\r\n");
          }
        }
      }
      Console.WriteLine("###################################################################################");
      Console.WriteLine("");
      Console.WriteLine("");
    }
  static string PrintOptions(){
    Console.WriteLine("What do you want to print?");
    Console.WriteLine("- All : Prints all people in Santas List");
    Console.WriteLine("- Naughty : Prints all naughy people in Santas List");
    Console.WriteLine("- Nice : Prints all nice users in Santas List");
    Console.Write("Command Entry : ");
    return Console.ReadLine();
  }
  
  static void UpdateDeliveredStatus(List<Person> SantaList){
    string personToUpdate;
    Boolean updateStatus;
    Console.WriteLine("Who do you want to update?");
    PrintList(SantaList, "all");
    Console.Write("Person to update: ");
    personToUpdate = Console.ReadLine().ToLower();
    Console.Write("Present Delivered? true/false : ");
    updateStatus = Convert.ToBoolean(Console.ReadLine());

    foreach(Person person in SantaList){
      if(person.name.ToLower().Equals(personToUpdate)){
        Console.WriteLine(person.UpdateDeliveredStatus(updateStatus));
      }
    }
  }
  // Don't go below here
  }
}