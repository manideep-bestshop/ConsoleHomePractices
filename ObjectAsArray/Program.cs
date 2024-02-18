using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAsArray
{
    class emp
    {
        private int EmpId;
        private string EmpName;
        private double EmpSal;

        public void GetInfo()
        {
            Console.WriteLine("enter emp id: ");
            EmpId=int.Parse(Console.ReadLine());

            Console.WriteLine("enter Emp Name");
            EmpName = Console.ReadLine();

            Console.WriteLine("enter emp sal");
            EmpSal=double.Parse(Console.ReadLine());    
        }
        public void show()
        {
            Console.WriteLine("EmpId= "+EmpId);
            Console.WriteLine("EmpName= "+EmpName);
            Console.WriteLine("empSal= "+EmpSal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emp[] e = new emp[2];

            for (int i = 0; i < e.Length; i++) 
                  e[i]=new emp();

            for (int i = 0; i < e.Length; i++)
                e[i].GetInfo();

            for (int i = 0; i < e.Length; i++)
                e[i].show();


        }
    }
}
