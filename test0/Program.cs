namespace test0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypeConverting();
            //GetTypeM();
            //InputM();
            //Artihmetic();
            //mathm();
            //randomm();
            //Hypotenuse();
        }

        static void DataTypeConverting()
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 44; // whole integer
            double height = 188.5; // decimal number
            bool alive = true; //true or false
            char symbol = '@'; // single character
            String name = "Lars"; // a series of characters

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);
            Console.WriteLine();
            Console.ReadKey();

            //type casting = Converting a value to a different data type
            //               Useful when we accept user input(string)
            //                Different data types can do different things

        }

        static void GetTypeM()
        {

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.Write(b + ": ");
            Console.WriteLine(b.GetType());
            Console.Write(d + ": ");
            Console.WriteLine(d.GetType());
            Console.Write(f + ": ");
            Console.WriteLine(f.GetType());
            Console.Write(h + ": ");
            Console.WriteLine(h.GetType());
            Console.Write(j + ": ");
            Console.WriteLine(j.GetType());
            Console.ReadKey();
        }

        static void InputM()
        {
            System.Console.WriteLine();
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.ReadKey();
        }

        static void Artihmetic()
        {
            int pluss = 5;

            pluss = pluss + 1;
            pluss += 1;
            pluss++;

            int minus = 5;

            minus = minus - 1;
            minus -= 1;
            minus--;

            int gange = 5;

            gange = gange * 2;
            gange *= 2;

            int dele = 5;

            dele = dele / 2;
            dele /= 2;

            int delerAvGjenst = 10;
            int remainder = delerAvGjenst % 2;
            

            Console.WriteLine(pluss);
            Console.WriteLine(minus);
            Console.WriteLine(gange);
            Console.WriteLine(dele);
            Console.WriteLine(remainder);
            Console.ReadKey();
        }

        static void mathm()
        {
            
            double x = 3.5;
            double y = 5;

            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.ReadKey();
        }

        static void randomm()
        {
            Random random = new Random();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }

        static void Hypotenuse()
        {
            
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}