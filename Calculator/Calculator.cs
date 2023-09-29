using System.Collections;

class Calculator
{
    public static void Main()
    {
        char ch;
        int n, n1, n2, res;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome To Calculator");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");
            Console.Write("Enter your choice: ");
             n = Convert.ToInt32(Console.ReadLine());
            
            switch(n)
            {
                case 1: Console.WriteLine("Enter First Number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        res = n1 + n2;
                        Console.WriteLine($"{n1} + {n2} = {res}");
                        break;
                 case 2: Console.WriteLine("Enter First Number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        res = n1 - n2;
                        Console.WriteLine($"{n1} - {n2} = {res}");
                        break;
                 case 3: Console.WriteLine("Enter First Number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        res = n1 * n2;
                        Console.WriteLine($"{n1} * {n2} = {res}");
                        break;
                 case 4: Console.WriteLine("Enter First Number: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        res = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {res}");
                        break;
                 case 5:
                        break;
            }
            Console.WriteLine("Do you want to continue:(y/n)");
            ch = Convert.ToChar(Console.ReadLine());
        } while (ch == 'y' || ch == 'Y');
        Console.WriteLine("Terminated Successfully, Thank You!!");
    }
}