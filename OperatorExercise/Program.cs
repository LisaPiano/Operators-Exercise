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
            Console.WriteLine($"Thanks again! So, if we add your two numbers, the result is {num1 + num2}");

        }
    }
}
