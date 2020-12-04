using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithEnums
{
    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,  
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums *****\n");
            // Создать переменную типа EmpType
            EmpType emp = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            EvaluateEnum(emp);
            EvaluateEnum(day);
           
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(cc);
            Console.ReadLine();
        }

        #region Enum as parameter
        // Enums as parameters.
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
        #endregion

        #region Just a test.  Uncomment to verify.
        static void ThisMethodWillNotCompile()
        {
            //EmpType emp = EmpType.SalesManager;
            //EmpType emp = Grunt;
        }
        #endregion

        #region Examine enum!
        // This method will print out the details of any enum.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", 
                e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            // Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", 
                enumData.Length);

            // Вывести строковое имя и ассоциированное значение,
            // использую флаг формата D
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                    enumData.GetValue(i));
            }
            Console.WriteLine();
        }
        #endregion

    }
}
