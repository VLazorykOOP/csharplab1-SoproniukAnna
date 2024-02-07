using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("          Lab 1");
        Console.WriteLine();
        /*Task1();
        Task2();
        Task3();
        Task4();

        Console.WriteLine("          Task 5");
        Console.Write("Input integer number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Number {a} in a cube: {Task5(a)}");
        Console.WriteLine();
        */
        Task6();
    }

    static void Task1()
    {
        Console.WriteLine("          Task 1");

        Console.Write("Input side a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double radius = a / (2 * Math.Sqrt(3));
        Console.WriteLine();
        Console.WriteLine($"Side a: {a}");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine();
    }

    static void Task2()
    {
        Console.WriteLine("          Task 2");
        Console.Write("Input side a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input side b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine($"Triangle with sides {a}, {b}, {c} exists");
        else
            Console.WriteLine($"Triangle with sides {a}, {b}, {c} not exists");
        Console.WriteLine();
    }

    static void Task3()
    {
        Console.WriteLine("          Task 3");
        Console.Write("Input coordinate x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input coordinate y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > -15 && x < 0 && y > -15 && y < 0)
            Console.Write("No");
        else if (x < -15 || x > 0 || y < -15 || y > 0)
            Console.Write("Yes");
        else
            Console.WriteLine("On the edge");
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Task4()
    {
        Console.WriteLine("          Task 4");
        Console.Write("Input the transport sign(а, в, м, с, п): ");
        char sign = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        int maxSpeed = 0;

        switch (sign)
        {
            case 'а':
                maxSpeed = 120;
                break;
            case 'в':
                maxSpeed = 30;
                break;
            case 'м':
                maxSpeed = 90;
                break;
            case 'с':
                maxSpeed = 900;
                break;
            case 'п':
                maxSpeed = 200;
                break;
            default:
                Console.WriteLine("There is no such sign");
                Console.WriteLine();
                return;
        }

        Console.WriteLine($"Max speed on the sign {sign}: {maxSpeed}");
        Console.WriteLine();
    }

    static int Task5(int a)
    {
        return a * a * a;
    }

    static void Task6()
    {
        Console.WriteLine("          Task 6");
        double x = 0;
        double y = 0;
        do
        {
            Console.WriteLine("Input number x and y which not 0");
            Console.Write("Input number x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number y: ");
            y = Convert.ToDouble(Console.ReadLine());
        } while (x == 0 || y == 0);

        double first = 1 / (x * y);
        double second = 1 / (x * x + 1);
        double third = first + second;
        double fourth = x + y;
        double result = third * fourth;

        Console.WriteLine($"Result: {result}");
    }
}

