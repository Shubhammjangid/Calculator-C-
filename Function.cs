namespace Calulator{
    abstract class Function{
        public abstract void Addition(int A,int B);

        public abstract void Subtraction(int A,int B);

        public abstract void Multiplication(int A, int B);

        public abstract void Division(int A,int B);

        public abstract void Square(int A);

        public abstract void SquareRoot(int A);

    }

    class Calculation:Function{
        public override void Addition(int A, int B)
        {
            Console.WriteLine($"The result is :{A + B}");
        }
        public override void Subtraction(int A, int B)
        {
            Console.WriteLine($"The result is {A - B}");
        }
        public override void Division(int A, int B)
        {
            if(B==0){
                Console.WriteLine($"The result is {B}, B cannot be 0");
            }
            else{
                Console.WriteLine($"The result is {A/B}");
            }
        }
        public override void Multiplication(int A, int B)
        {
            Console.WriteLine($"The result is {A * B}");
        }

        public override void Square(int A)
        {
            Console.WriteLine($"The Square of given number is {A*A}");
        }
        public override void SquareRoot(int A)
        {
            Console.WriteLine($"The squareroot is {Math.Round(Math.Sqrt(A),2)}");

        }
    }
}