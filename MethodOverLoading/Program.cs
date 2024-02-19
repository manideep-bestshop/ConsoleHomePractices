using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class ParamsEx
    {
        public void show(params int[] arr)   // it called with zero or more arguments
        {
            foreach (int i in arr)
            {
                Console.Write(i+" ");
                Console.WriteLine("no arguments");
            }
        }
        public void show(int a,params int[] arr) // it can be called with one or more arguments
        {
            foreach (int i in arr)
            {
                Console.Write(i + " "+a);
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        public void show()
        {
            Console.WriteLine("with no arguments");
        }
        public void show(int n)
        {
            Console.WriteLine("with arguments= "+n);
        }
        public void show(double m)
        {
            Console.WriteLine("with arguments Double= "+m);
        }
        static void Main(string[] args)
        {
         //   Program p=new Program();
           // p.show();
            //p.show(25);
            //p.show(18.5);

            ParamsEx pe = new ParamsEx();
            pe.show();
             pe.show(1,5,23,34,44,66);
        }
    }
}
