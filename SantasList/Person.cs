using System;

namespace SantasList{
  public class Person{
    private string name;
    /*
      Can I make address an Object as well?
      Would have street, street2, city, state, zipcide
    */
    // private string address;
    private string behavior;
    private string present;
    private Boolean status;

    public Person(string name, string behavior, Boolean status){
      this.name = name;
      this.behavior = behavior;
      this.status = status;
    }

    
  }
}