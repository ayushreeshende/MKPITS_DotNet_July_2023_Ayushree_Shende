using System;


namespace divide
{
    internal class Divide
    {
       public static void Main()
        {
        int num1, num2, divide;
        Console.WriteLine("enter num1");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter num2");
        num2 = Convert.ToInt32(Console.ReadLine());
        divide = num1 / num2;
        Console.WriteLine("result=" + divide);
        Console.ReadKey();
        }
    }

}