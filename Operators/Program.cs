// See https://aka.ms/new-console-template for more information
namespace OperatorsInClass
{
    class Program
    {
        static void Main (string[] args)
        {
            //For Division

            int a = 17;
            int b = 4;
            var sum = a + b;
            var difference = a - b;
            var product = a * b;

            var quotient = a/b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Please enter the radius of your circle?");
            var Userinput = Console.ReadLine();

            double radius = double.Parse(Userinput);

            Console.WriteLine($"The area of your circle with a radius of {Userinput} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
