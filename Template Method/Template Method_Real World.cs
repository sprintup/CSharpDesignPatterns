using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace Template_Method
{
    class Template_Method_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates a Template method named Run() which provides a skeleton calling sequence of methods. Implementation of these steps are deferred to the CustomerDataObject subclass which implements the Connect, Select, Process, and Disconnect methods.\n");
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();
            /*
            Categories ----
            Beverages
            Condiments
            Confections
            Dairy Products
            Grains/Cereals
            Meat/Poultry
            Produce
            Seafood

            Products ----
            Chai
            Chang
            Aniseed Syrup
            Chef Anton's Cajun Seasoning
            Chef Anton's Gumbo Mix
            Grandma's Boysenberry Spread
            Uncle Bob's Organic Dried Pears
            Northwoods Cranberry Sauce
            Mishi Kobe Niku             
             */
        }
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
    }
}
