using System;
class Person {

    public string givenName;
    public string familyName;

    public Person(string givenName, string familyName) {
        this.givenName = givenName;
        this.familyName = familyName;
    }
    public void EasternStyleName() {
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }
    
    public void WesternStyleName() {
        Console.WriteLine($"{this.givenName} {this.familyName}");
    }


}