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
            Console.WriteLine("Ad");
            Console.WriteLine("Sub");
            Console.WriteLine("Mul");
            Console.WriteLine("Div");
            switch (Console.ReadLine())
    {
            case "Ad":
                Console.WriteLine($"The result is:{Op.Add(A,B)}");
                break;
            case "Sub":
                Console.WriteLine($"The result is:{Op.Subtract(A,B)}");
                break;
            case "Mul":
                Console.WriteLine($"The Result is: {Op.Multiply(A,B)}");
                break;
            case "Div":
                Console.WriteLine($"The Result is: {Op.Division(A,B)}");
                break;
    }   
        }
    }
