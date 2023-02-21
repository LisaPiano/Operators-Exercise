namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Would you please give me one number? Type it here:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks! Now, would you please give me one more number? Type it here:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Thanks again! So, if we add your two numbers, the result is {num1 + num2}.");
            Console.WriteLine($"If we subtract your first number from your second number, the result is {num2-num1}.");
            Console.WriteLine($"If we multiply your two numbers together, the result is {num1 * num2}.");
            Console.WriteLine($"If we divide the first number by the second number the remainer is {num1 % num2}.");

            int a = 17;
            int b = 4;


            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }





        }
    }
}
