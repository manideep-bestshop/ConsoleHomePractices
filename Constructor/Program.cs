using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx
{
    class Demo
    {
        private int i;
        public Demo() //Parameter less Constructor
        {
            Console.WriteLine("enter value of i:");
            i=int.Parse(Console.ReadLine());
        }
        public Demo(int k) // parameterized Constructor
        {
            
            i = k;
        }
        public Demo(Demo d)
        {
            i = d.i;
        }
        public void show()
        {
            Console.WriteLine("i= "+i);
        }
    }
    class demo1
    {
        private int i;
        private bool j;
        private double k;

        private demo1()  // private constructor 
        {
            i = 10;j = true;k = 9.1;
            show();
        }
        public demo1(int n,bool m,double l):this() // when constructor is private we can call using this()
        {
            i = n;j = m;    k = l;  
        }
        public void show()
        {
            Console.WriteLine(i+" "+j+" "+k);
        }
    }
    class demo2
    {
        private int i;
        public demo2()
        {
            Console.WriteLine("from constructor.."+i);
            show();
        }
        public void show()
        {
            Console.WriteLine("from show method");
        }
    }
    class student
    {
        public int RNo;
        public string SName;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1=new Demo();
            Demo d2=new Demo(66);
            Demo d3 = new Demo(d1);

            d1.show();
            d2.show();
            d3.show();

            demo1 dm1 = new demo1(1001, true, 189.11);
            dm1.show();

            demo2 dm2 = new demo2(); //named object
            new demo2(); //anonymous object
            new demo2().show();// anonymous / nameless object

            student s = new student() { RNo = 1, SName = "MANIDEEP", marks = 84 };
            Console.WriteLine(s.RNo+" "+s.SName+" "+s.marks);
        }
    }
}
