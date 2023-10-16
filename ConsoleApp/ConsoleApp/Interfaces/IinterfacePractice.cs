namespace ConsoleApp.Interfaces;

public interface IInterfacePractice
{
    void sound();
}



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
    

