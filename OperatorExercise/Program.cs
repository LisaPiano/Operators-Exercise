using System.Runtime.CompilerServices;

namespace OperatorExercise
{
    public class Program
    {
        //The Second Exercise--declaring a method that calculates the area of a circle
        public static double AriaOfCircle(double radius) 
        {
            double answer = Math.PI * radius * radius;
            return answer;
        }
     
      
       
        static void Main(string[] args)
        {
            //The first Exercise
            
            Console.WriteLine("Hello! Would you please give me one number? Type it here:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks! Now, would you please give me one more number? Type it here:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Thanks again! So, if we add your two numbers, the result is {num1 + num2}.");
            Console.WriteLine($"If we subtract your first number from your second number, the result is {num2-num1}.");
            Console.WriteLine($"If we multiply your two numbers together, the result is {num1 * num2}.");
            Console.WriteLine($"If we divide the first number by the second number the remainder is {num1 % num2}.");

            int a = 17;
            int b = 4;


            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            //The Second Exercise--calling the method
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double answer = AriaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {answer} ");
        }
    }

}
