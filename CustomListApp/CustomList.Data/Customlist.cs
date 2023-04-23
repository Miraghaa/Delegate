

namespace CustomList.Data
{
    public class MyList<T>
    {
        private List<T> _items;

        public MyList()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Find(Predicate<T> func)
        {
            return _items.Find(func);
        }
    }
}
