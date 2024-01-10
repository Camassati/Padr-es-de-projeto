namespace InteraitorPattern.C_
{
    internal interface IAggregate<T>
    {
        T this[int index] { get; set; }

        int Count { get; }
        IITerator<T> Iterator { get; }
    }

    internal class Aggregate<T> : IAggregate<T>
    {
        private IITerator<T> _iterator;
        private List<T> _list = new List<T>();

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list.Add(value); }
        }
        public IITerator<T> Iterator
        {
            get
            {
                if (this._iterator == null) _iterator = new ITerator<T>(this);
                return _iterator;
            }
        }
        public int Count => _list.Count;
    }

}
