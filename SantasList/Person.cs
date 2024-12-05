using System;

namespace SantasList{
  public class Person{
    private string name;
    /*
      Can I make address an Object as well?
      Would have street, street2, city, state, zipcide
    */
    // private string address;

    // Can I make behavior an enum? 
    private string behavior;
    private string present;
    private Boolean status;

    public Person(string name, string behavior, Boolean status){
      this.name = name;
      this.behavior = behavior;
      this.status = status;
    }

    public override string ToString()
    {
      return "Name: "+this.name+"\r\n"+"Naughty or Nice? "+this.behavior+"\r\n"+"Delivered Present? "+this.status;
    }
  }
}