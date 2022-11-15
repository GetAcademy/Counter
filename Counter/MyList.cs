using System.Collections;

namespace Counter
{
    internal class MyList : IEnumerable<int>,
        IEnumerator<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            Current *= 2;
            return Current < 1000;
        }

        public void Reset()
        {

        }

        public int Current { get; private set; } = 1;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
