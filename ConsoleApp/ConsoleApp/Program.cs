using ConsoleApp.Abstraction;
using ConsoleApp.Conditions_and_Loops;
using ConsoleApp.Constructors;
using ConsoleApp.Interfaces;
using ConsoleApp.Methods;
using ConsoleApp.This_keyword;
using ConsoleApp.Tuple;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CommentedCode
            // Conditionss obj = new Conditionss();
            // obj.Conditions();
            //SwitchStatement obj2 = new SwitchStatement();
            //obj2.SwitchStatements();
            //For_Loop obj3 = new For_Loop();
            //obj3.loop();
            //obj3.multiplication();
            //obj3.starPattern();
            //obj3.fibonacci();
            //Method method = new Method();
            //method.Result();
            //Method studentinfo = new Method();
            //studentinfo.ShowStudentInformation();
            //Method temp = new Method();
            //temp.displayTemperature();
            //temp.displayArrayAddition();
            //ParametersOfDifferentDataTypes obj = new ParametersOfDifferentDataTypes();
            //obj.viewDataTypes();
            //MethodOverloading obj = new MethodOverloading();
            //obj.viewInformaiton();
            
            //TupleExample obj = new TupleExample();
            //obj.displayInfo();
            //This obj2 = new This();
            //obj2.PI();
            // CreatingConstructors obj = new CreatingConstructors();
            // obj.Details();
            // Car obj = new Car();
            // obj.sound();
            #endregion

            Sameer obj = new Sameer();
            obj.StudentData();
            Milan obj2 = new Milan();
            obj2.StudentData();
        }
    }
}