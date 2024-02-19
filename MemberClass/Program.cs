using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClass
{
    class Car
    {
        private string CName;
        public void GetData()
        {
            CName = "Car";
        }
        public void Display()
        {
            Console.WriteLine(CName);
        }
        public class Sterio
        {
            private string SName;
            public void GetInfo()
            {
                SName = "Sterio";
            }
            public void show()
            {
                Console.WriteLine(SName);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c=new Car();
            Car.Sterio s=new Car.Sterio();

            c.GetData();
            s.GetInfo();

            c.Display();
            s.show();
        }
    }
}
