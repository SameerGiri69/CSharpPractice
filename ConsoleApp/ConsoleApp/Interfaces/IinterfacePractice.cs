namespace ConsoleApp.Interfaces;

public interface IInterfacePractice
{
    void sound();
}

public interface Life
{
    void AliveOrNot();
}
// a class must implement methods and properties set by the interface else there'll be compile errors


public class Car : IInterfacePractice, Life
    {
         public void sound()
        {
            Console.WriteLine("vrrrr vrrrr");
        }

         public void AliveOrNot()
         {
             Console.WriteLine("The car is a non living thing");
         }
    }

   public class Animal : IInterfacePractice, Life
   {
       public void sound()
       {
           Console.WriteLine("meoww");
       }

       public void AliveOrNot()
       {
           Console.WriteLine("Animal is a living thing");
       }
   }
    

