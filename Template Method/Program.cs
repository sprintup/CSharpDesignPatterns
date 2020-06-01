using System;
using System.Data;
using System.Data.OleDb;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Template Method");

            //Real-world C#
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            Console.WriteLine("\n----\n");
            // Structural C#
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            Console.ReadKey();
        }
    }
    // The 'AbstractClass' abstract class
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            connectionString = "provider=Microsoft.JET.OLEDB.4.0;" + "data source=..\\.\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = " ";
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
    abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
    // A 'ConcreteClass' class
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }
        public override void Process()
        {
            Console.WriteLine("Categories ----- ");
            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
    class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
    // A 'ConcreteClass' class
    class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ----- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}
