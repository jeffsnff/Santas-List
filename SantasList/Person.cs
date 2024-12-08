using System;

namespace SantasList{
  public class Person{
    public string name;
    /*
      Can I make address an Object as well?
      Would have street, street2, city, state, zipcide
    */
    // private string address;

    // Can I make behavior an enum? 
    public string behavior;
    private string present;
    private Boolean deliveredStatus;

    public Person(string name, string behavior){
      this.name = name;
      this.behavior = behavior;
      this.deliveredStatus = false;
    }
    public override string ToString()
    {
      return "Name: "+this.name+"\r\n"+"Naughty or Nice? "+this.behavior+"\r\n"+"Delivered Present? "+this.deliveredStatus;
    }

    public Boolean DeliveredStatus(){
      return this.deliveredStatus;
    }
    public string UpdateDeliveredStatus(Boolean deliveredStatus){
      this.deliveredStatus = deliveredStatus;
      return this.name+" delivered status has been updated.";
    }
    public string AddPresent(string present){
      this.present = present;
      return this.name+" present will be "+this.present;
    }
  }
}