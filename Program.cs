using System;
namespace Calulator; 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MainSystem

            try{
                Calculation Op = new Calculation();
                Option Ok = new Option();
                Console.WriteLine("please enter the Number1");  
                int A = Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine("-----------------------");
                Console.WriteLine("please enter the Number2");  
                int B = Convert.ToInt32(Console.ReadLine());

                bool Value=false;

                while(!Value){
                        Ok.Optionn();
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

                    case 7:
                        Console.WriteLine("Enter 7 once again to exit from App");
                        int Exit = Convert.ToInt32(Console.ReadLine());
                        if(Exit==7){
                            Value=true;
                        }
                        break;

                    default:
                        Console.WriteLine("Enter the proper Number");
                        break;
            }   
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
