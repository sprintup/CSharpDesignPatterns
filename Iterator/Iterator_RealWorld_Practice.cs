using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Iterator_RealWorld_Practice
    {
        public static void Run()
        {
            Console.Write("Iterator Real World Practice");
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            Iterator iterator = collection.CreateIterator();
            iterator.Step = 2;
            Console.WriteLine("\nIterating over collection");
            for (Item item1 = iterator.First(); !iterator.IsDone; item1 = iterator.Next())
            {
                Console.WriteLine(item1.Name);
            }
        }
        interface IAbstractCollection
        {
            Iterator CreateIterator();
        }
        class Collection : IAbstractCollection
        {
            private ArrayList _items = new ArrayList();
            public Iterator CreateIterator()
            {
                return new Iterator(this);
            }
            public int Count
            {
                get { return _items.Count; }
            }
            public object this[int index]
            {
                get { return _items[index]; }
                set { _items.Add(value); }
            }
        }
        interface IAbstractIterator
        {
            Item First();
            Item Next();
            bool IsDone { get; }
            Item CurrentItem { get; }
        }
        class Iterator : IAbstractIterator
        {
            private Collection _collection;
            private int _current = 0;
            private int _step = 1;

            public Iterator(Collection collection)
            {
                this._collection = collection;
            }
            public Item First()
            {
                _current = 0;
                return _collection[_current] as Item;
            }
            public Item Next()
            {
                _current += _step;
                if (!IsDone)
                    return _collection[_current] as Item;
                else
                    return null;
            }
            public int Step
            {
                get { return _step; }
                set { _step = value; }
            }
            public Item CurrentItem
            {
                get { return _collection[_current] as Item; }
            }
            public bool IsDone
            {
                get { return _current >= _collection.Count; }
            }
        }
        class Item
        {
            private string _name;

            public Item(string name)
            {
                this._name = name;
            }
            public string Name
            {
                get { return _name; }
            }
        }
    }
}
