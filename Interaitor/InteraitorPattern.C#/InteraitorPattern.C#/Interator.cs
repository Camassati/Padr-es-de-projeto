namespace InteraitorPattern.C_
{
    internal interface IITerator<T>
    {
        T Next();
        T Current { get; }
        bool IsLeft();
    }
    internal record Person(string Name, int Age);
    internal class ITerator<T> : IITerator<T>
    {
        public readonly IAggregate<T> _aggregate;
        int index = 0;
        public ITerator(IAggregate<T> aggregate)
        {
            this._aggregate = aggregate;
        }

        public T Current => _aggregate[index];

        public bool IsLeft() => index < _aggregate.Count;
      
        public T Next()
        {
            index++;
            return IsLeft()? _aggregate[index]: default;
        }
    }
}
