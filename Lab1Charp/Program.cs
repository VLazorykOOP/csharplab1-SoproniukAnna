// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("          Task 1");

    Console.Write("Input side a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double radius = (a / (2 * Math.Sqrt(3)));
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
Console.WriteLine("          Lab 1");
//task1();
task2();
// continue ...
