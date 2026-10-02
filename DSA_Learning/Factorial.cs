public class Factorial
{
    public static int FactorialOfNumber(int n)
    {
        // Base Case: n = 0 or 1
        if (n <= 1)
        {
            return 1;
        }
        // Recursie Case: n! = n * (n - 1)!
        return n * FactorialOfNumber(n-1);
        
    }
}