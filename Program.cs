using System;
namespace Calulator; 
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation Op = new Calculation();
            Console.WriteLine("please enter the Number1");  
            int A = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("please enter the Number2");  
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("Addition --/ 1 ");    //Addition
            Console.WriteLine("Subtraction --/ 2");   //Subtraction
            Console.WriteLine("Multiplication --/ 3");   //Multiplication
            Console.WriteLine("Division --/ 4");  //Division
            Console.WriteLine("Square --/ 5");   //square
            Console.WriteLine("Square root --/ 6");
            Console.Write("Select one option -- ");
            switch (Convert.ToInt32(Console.ReadLine()))
    {
            case 1:
                Op.Addition(A,B);
                break;
            case 2:
                Op.Subtraction(A,B);
                break;
            case 3:
                Op.Multiplication(A,B);
                break;
            case 4:
                Op.Division(A,B);
                break;
            case 5:
                Op.Square(A);
                Op.Square(B);
                break;
            case 6:
                Op.SquareRoot(A);
                Op.SquareRoot(B);
                break;
            default:
                Console.WriteLine("Enter the proper Number");
                break;

    }   
        }
    }
