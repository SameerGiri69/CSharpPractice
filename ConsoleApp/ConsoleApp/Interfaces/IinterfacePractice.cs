namespace ConsoleApp.Interfaces;

public interface IInterfacePractice
{
    void sound();
}
// a class must implement methods and properties set by the interface else there'll be compile errors


   public class Car : IInterfacePractice
    {
         public void sound()
        {
            Console.WriteLine("vrrrr vrrrr");
        }
    }

   public class Animal : IInterfacePractice
   {
       public void sound()
       {
           Console.WriteLine("meoww");
       }
   }
    

