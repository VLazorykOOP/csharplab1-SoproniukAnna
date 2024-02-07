// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("          Task 1");

    Console.Write("Input side a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double radius = a / (2 * Math.Sqrt(3));
    Console.WriteLine();
    Console.WriteLine("Side a: " + a);
    Console.Write("Radius: " + radius);
    Console.WriteLine();
}

static void task2()
{
    Console.WriteLine("          Task 2");
    Console.Write("Input side a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input side b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input side c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine("Triangle exists");
    else
        Console.WriteLine("Triangle not exists");
    Console.WriteLine();
}

static void task3()
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
        Console.Write("On the edge");
    Console.WriteLine();
}

static void task4()
{
    Console.WriteLine();
    Console.Write("Input the transport sign(а, в, м, с, п): ");
    char sign = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();

    int maxSpeed = 0;

    switch (sign)
    {
        case 'a':
            maxSpeed = 120;
            break;
        case 'в':
            maxSpeed = 30;
            break;
        case 'м':
            maxSpeed = 120;
            break;
        case 'с':
            maxSpeed = 900;
            break;
        case 'п':
            maxSpeed = 200;
            break;
        default:
            Console.WriteLine("There is no such sign");
            return;
    }
    Console.WriteLine("Max Speed: " + maxSpeed);
}

Console.WriteLine("          Lab 1");
//task1();
//task2();
//task3();
task4();
// continue ...
