using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApp1
{
    public class Reflection
    {
        public void Test()
        {
            Type t = Type.GetType("Customer");
            PropertyInfo[] prop = t.GetProperties();
            Customer c = new Customer();
           
        }
    }

    public class Customer
    {
        public string Customername { get; set; }

        public int CustAge { get; set; }

    }
}
