using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину катета a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину катета b: ");
        //Нахождение S
        int b = Convert.ToInt32(Console.ReadLine());
        double S = 0.5 * a * b;
        Console.WriteLine(S);
    }
}
