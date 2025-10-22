using System.Timers;
using Timer = System.Timers.Timer;

namespace _11.Miscellaneous._02.Diagnostics
{
    class _02_Timer
    {
        void ThisIsMain()
        {
            Timer timer = new Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 3000;
            timer.Enabled = true;

            Console.WriteLine("Press X to exit");
            while (Console.Read() != 'x')
            {

            }
        }

        private void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
