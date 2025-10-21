namespace _04.ControlFlowAndDecisionMaking
{
    class _05_TernaryOperators
    {
        void SimpleMethod()
        {
            if (otherMethod())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //Ternary Operator
            //condition ? if true : if false
            Console.WriteLine(otherMethod() ? "True" : "False");
        }
        bool otherMethod()
        {
            return false;
        }
    }
}
