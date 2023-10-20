namespace ConsoleApp.Abstraction;

abstract class Abstract
{
    //abstract classes are similar to interfaces but you can use abstract classes to predefine a method which is not possible in interfaces
    //we can then override the method to create our own implementation
    public virtual void StudentData()
    {
        Console.WriteLine("My name is milan");
    }
}

class Sameer : Abstract
{
    public override void StudentData()
    {
        Console.WriteLine("My name is sameer");
    }

}

class Milan : Abstract
{
    public override void StudentData()
    {
        base.StudentData();
    }
}