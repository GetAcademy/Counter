namespace Counter.Lib
{
    public class Countdown
    {
        private int _count;
        private readonly IApp _app;

        public Countdown(IApp app)
        {
            _app = app;
            _count = 10;
        }

        public void Count()
        {
            _count--;
            if (_count == 0)
            {
                _app.CountdownFinished();
            }
        }
    }
}
