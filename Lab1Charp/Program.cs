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
}

static void task2()
{ 

}
Console.WriteLine("          Lab 1");
task1();
task2();
// continue ...
