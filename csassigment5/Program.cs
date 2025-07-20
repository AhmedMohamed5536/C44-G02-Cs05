

//---------( part01)

/*
using System.Security.Cryptography.X509Certificates;

namespace csassigment5_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("V01");

            //Boxing And UnBoxing

            //Boxing : casting from valuetype to reference
            //UnnBoxing : casting from reference to valuetype

            // object o1;

            // o1 => can refer to instance "object" or any instance of any type

            // o1 = 1;
            // o1 = "Ahmed";

            // o1 = 2;                 // cast from valuetype{int} to referencetype[object] => Boxing
            // o1 = 1.5;              // cast from valuetype{double} to referencetype[object] => Boxing
            // o1 = 'A';              // cast from valuetype{char} to referencetype[object] => Boxing
            // o1 = true;             // cast from valuetype{bool} to referencetype[object] => Boxing
            // o1 = new DateTime();   // cast from valuetype{Datetime} to referencetype[object] => Boxing

            // int x = 5;
            // object o1 = /*(object)* J;/ 


            // Implicit casting
            // safe casting
            // Boxing
            //parent = chaild  => child is parent

            // Animal = Dog   => Dog is animal

            // object o1 = 3;

            // int x = (int)o1;

            //Explicting casting
            // Unsafe casting [May throw exception]
            // unBoxing
            // Dog = (Dog) Animal  => Animal is Dog
            // child = parent => parent is child

//            Console.WriteLine("V02");

            // Mullable Types

            // Value Type
            // Reference Type

            // int x = 6;
            // x = null;   // Not Valid

            /////// Nullable value Type => value Allow null as valid value

            // Nulllable<int> : Allow int value or null as valid value
            // int? age = 20;


            // age = null ;

            // nullable <double> : Allow double value or null as valid value
            // double? salary = 4000.5;

            // salary = null ; 

            // int x = 5;

            // Y : Nullable<int>
            // Y : Allow int Value or Null 

            // int? Y = /* (int?) x; */

// Implicit casting
// safe casting

// Console.WriteLine(Y);

// int? x = 5;

// x = null;
// Y : int
// Y : Allow int value only

// int Y = (int)x;
// Explicit casting
// May Throw Excepton

// if (x != null)
//     y = (int)X;
// else
// {
//     y = 0;

// }
// Console.WriteLine(Y);



//// Nullable Reference 
///
/// Nullable Reference Type [ C# 10.0 .NET 6.0]
/// 

// string massage null ;   ===> Required
// string? massage = null; ==> Nullable

// string massage = "Hello";
// massage = null;

// console.writline(massage);


///////// Null propagation operator ?
///
//double x = default;  //0
//bool c = defult; //false
//console.writline(c);

//int[]arr = defult; //null;


//-------------------------

// Exption handling and protective code
// Try -- catch

// Exception :
// 1. systemException
// 1.1 formatException
// 1.2 IndexoutofRangeException
// 1.3 NullReferenceException
// 1.4 ArithmeticException
// 1.4.1 overflowException
//1.4.2 DivideByZeroException


// 2. ApplicationException


//--------------------------
// class





//       }
// }
//}




//---------(part02)

//-------------------------------------------------------------------------------------------------------------------------------


// 1 

/*
namespace csassignment5_
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of the week are:");


            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();
        }
    }
}
*/

//--------------------------------------
// 2.

/*


namespace EnumExample
{
    enum Season
    {
        Spring,Summer, Autumn, Winter
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();


            bool isValid = Enum.TryParse(input, true, out Season season);

            if (isValid)
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Months: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Months: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Months: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Months: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered!");
            }

            Console.ReadLine();
        }
    }
}
+/


// -------------------------------------------------..
// 5. 
/*


namespace EnumExample
{
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a color name (Red, Green, Blue): ");
            string input = Console.ReadLine();

            bool isValid = Enum.TryParse(input, true, out Colors color);

            if (isValid)
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine("The entered color is not a primary color.");
            }

            Console.ReadLine();
        }
    }
}


*/
