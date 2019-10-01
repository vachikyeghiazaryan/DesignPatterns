using System.Collections;

namespace Builder
{
    public class House
    {
        private readonly ArrayList _items;

        public House()
        {
            this._items = new ArrayList();
        }

        public void Add<T>(T item)
        {
            this._items.Add(item);
        }
    }
}