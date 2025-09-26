namespace operators;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine("voorbeeld1 is nu 30 zie " + voorbeeld1);

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine("voorbeeld2 is nu 20 zie " + voorbeeld2 + ", wie is wel 30");

        int voorbeeld3 = 20;
        int result2 = voorbeeld3 += 10;
        Console.WriteLine($"voorbeeld3 is nu 30 , zie: {voorbeeld3}. result2 ook {result2} ");




        int plus = 9;
        Console.WriteLine("plus start nu met: " + plus);
        plus++;
        Console.WriteLine("plus eindigt nu met: " + plus);
        plus--;
        Console.WriteLine("plus is nu weer: " + plus);
        plus--;
        Console.WriteLine("plus is nu weer: " + plus);
        */


        int a = 20;
        a = a -= 10;
        Console.WriteLine("a is nu: " + a);

        double b = 6;
        b = b *= 2;
        Console.WriteLine("b is nu: " + b);

        int c = 10;
        c = c /= 2;
        Console.WriteLine("c is nu: " + c);
    }
}
