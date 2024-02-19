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

        private demo1()
        {
            i = 10;j = true;k = 9.1;
            show();
        }
        public demo1(int n,bool m,double l):this()
        {
            i = n;j = m;    k = l;  
        }
        public void show()
        {
            Console.WriteLine(i+" "+j+" "+k);
        }
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
        }
    }
}
