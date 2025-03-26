using static System.Console;

public class Program
{
    public static void Main()
    {
        WriteLine(Calculator.AddValues(2, 3));
        WriteLine(Calculator.AddValues(2.0f, 3.0f));
        WriteLine(Calculator.AddValues(2L, 3L));
    }
}

public static class Calculator
{
    // Method to add two integers
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    // Method to add two floats
    public static float AddValues(float a, float b)
    {
        WriteLine("Calculated by method: public static float AddValues(float a, float b)");
        return a + b;
    }

    // Method to add two longs
    public static long AddValues(long a, long b)
    {
        WriteLine("Calculated by method: public static long AddValues(long a, long b)");
        return a + b;
    }
}
