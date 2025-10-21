namespace _07.MethodsAndFunctions
{
    class _05_RecursiveMethods
    {
        int Factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
