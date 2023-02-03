namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)

                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var answer = AreaOfCircle(radius);
            Console.WriteLine($"The circle with radius {radius} is {answer}");
        }
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);
        }       
    }
}
