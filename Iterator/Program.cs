using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Iterator");
            //Real-world C#

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

            // Structural C#
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator1 i = a.CreateIterator();

            Console.WriteLine("Iterating over collection");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
    // The collection item
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
    abstract class Aggregate
    {
        public abstract Iterator1 CreateIterator();
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
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override Iterator1 CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
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
    abstract class Iterator1
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
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
    class ConcreteIterator : Iterator1
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count -1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
