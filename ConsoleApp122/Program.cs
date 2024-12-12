using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122
{
    class Student
    {
        private string name;
        private string address;
        private double mark;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public double Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
        static void Main(string[] args)
        {
            Student SSOF = new Student();
            SSOF.Name = "safer al hussen";
            SSOF.Address = "Baghdad";
            SSOF.Mark = 88;
            Console.WriteLine("the Name is: " + SSOF.Name);
            Console.WriteLine("the Address is: " + SSOF.Address);
            Console.WriteLine("the Mark is: " + SSOF.Mark);
            Console.ReadKey();
        }
    }
}
