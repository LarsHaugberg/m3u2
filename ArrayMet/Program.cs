namespace ArrayMet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

             String[] carss = {"BMW", "Volvo", "Lada"};

            String[] cars = new string[3];

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            // foreach loop = a simpler way to iterate over an array,
            // but it's less flexible

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (String car in carss)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}