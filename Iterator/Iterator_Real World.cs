using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Iterator_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Iterator pattern which is used to iterate over a collection of items and skip a specific number of items each iteration.");
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

            Console.WriteLine("Iterating over collection");

            for (Item item1 = iterator.First();
                !iterator.IsDone; item1 = iterator.Next())
            {
                Console.WriteLine(item1.Name);
            }
            /*
            Iterating over collection:
            Item 0
            Item 2
            Item 4
            Item 6
            Item 8
             */
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
        // The 'Aggregate' interface
        interface IAbstractCollection
        {
            Iterator CreateIterator();
        }

        // The 'ConcreteAggregate' class
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

        // The 'Iterator' interface
        interface IAbstractIterator
        {
            Item First();
            Item Next();
            bool IsDone { get; }
            Item CurrentItem { get; }
        }

        // The 'ConcreteIterator' class
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
    }
}
