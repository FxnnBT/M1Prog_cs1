namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        int a = 1;
        double b = 1.9;
        float vx = 9.87f;
        bool ja = true;
        string meerdereVariablen = a + " + " + b + " = " + (a + b);

        Console.WriteLine($"mijn int met de naam a heeft dezelfde waarde als {a}");
        Console.WriteLine($"mijn double met de naam b heeft dezelfde waarde als {b}");
        Console.WriteLine($"mijn float met de naam vx heeft dezelfde waarde als {vx}");
        Console.WriteLine($"mijn bool met de naam ja heeft dezelfde waarde als {ja}");
        Console.WriteLine($"mijn string is een som hier komt ie. {meerdereVariablen} ");
    }
}
