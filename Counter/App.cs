using Counter.Lib;

namespace Counter
{
    internal class App : IApp
    {
        public void Run()
        {
            var countdown = new Countdown(this);

            countdown.Count();
            countdown.Count();
            countdown.Count();
            countdown.Count();
            countdown.Count();

            countdown.Count();
            countdown.Count();
            countdown.Count();
            countdown.Count();
            countdown.Count();
        }

        public void CountdownFinished()
        {
            Console.WriteLine("Bang");
        }
    }
}
