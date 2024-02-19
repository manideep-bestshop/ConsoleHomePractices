using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExa
{
    class B1
    {
        private int i;
        public int j;
        protected int k;
        
        static B1()
        {
            Console.WriteLine("From static constructor B1 Class");
        }
        public B1()
        {
            Console.WriteLine("From parameterless constructor B1 Class");
        }
        public B1(int m):this()
        {
            Console.WriteLine("From sigle parameter constructor B1 Class "+m);
        }
        public void show()
        {
            Console.WriteLine("Base : "+i+""+j+""+k);
        }
        public static void Retr()
        {
            Console.WriteLine("from static Retr method of B1");
        }
        ~B1()
        {
            Console.WriteLine("from destructor of B1 class");
        }

    }
    class D1:B1
    {
        private int p;
        public int q;
        protected int r;
        public new double j;

        static D1()
        {
            Console.WriteLine("static cons of D1 class");
        }
        public D1():base(33)
        {
            Console.WriteLine( "parameterless cons from D1");
        }
        public D1(int n):this()
        {
            Console.WriteLine("from single parameter of D1"+n);
        }
        public new void show()
        {
            Console.WriteLine("Derives :"+p+""+q+""+r);
            base.show();
            int j = 19;
            Console.WriteLine(j+" "+this.j+" "+base.j);

        }
        ~D1()
        {
            Console.WriteLine("from Destructor of D1 class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // B1 b1 = new B1();
            D1 d1 = new D1(99);
            Console.WriteLine( d1.j+""+d1.q);
            d1.show();
            B1.Retr();
            D1.Retr();
        }
    }
}
