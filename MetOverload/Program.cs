namespace MetOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            double total;
            double tot;
            total = Multiply(2, 3, 4);
            tot = Multiply(2, 3);
            Console.WriteLine(tot);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {      
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}