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
    private Boolean deliveredStatus;

    public Person(string name, string behavior, Boolean deliveredStatus){
      this.name = name;
      this.behavior = behavior;
      this.deliveredStatus = deliveredStatus;
    }
    public override string ToString()
    {
      return "Name: "+this.name+"\r\n"+"Naughty or Nice? "+this.behavior+"\r\n"+"Delivered Present? "+this.deliveredStatus;
    }

    public Boolean DeliveredStatus(){
      return this.deliveredStatus;
    }
    public void UpdateDeliveredStatus(Boolean deliveredStatus){
      this.deliveredStatus = deliveredStatus;
    }
    public string AddPresent(string present){
      this.present = present;
      return this.name+" present will be "+this.present;
    }
  }
}