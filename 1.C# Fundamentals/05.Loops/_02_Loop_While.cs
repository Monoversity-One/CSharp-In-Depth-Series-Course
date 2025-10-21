namespace _05.Loops
{
    public class _02_Loop_While
    {
        void SimpleMethod()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 8)
                {
                    break;
                }
            }

            i = 10;
            while (i > 0)
            {
                Console.WriteLine(i * 2);
                i--;
            }

            i = 1;
            do
            {
                Console.WriteLine("Executes at least one time");
                i++;
            } while (i < 1);
        }
    }
}
