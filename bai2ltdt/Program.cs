using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2ltdt
{
    class Employee
    {
        int id, yearofbirth;
        string name;
        double salarylevel;
        public static double basicSalary;
        public int getid(int a)
        {
            id = a;
            return id;
        }
        public string getname()
        {
            do
            {
                Console.Write("Ten:");
                name = Console.ReadLine();
            }
            while (name == "");
            return name;
        }
        public int getyearofbirth(int a)
        {
            yearofbirth = a;
            return yearofbirth;
        }
        public double setSalarylevel(double a)
        {
            salarylevel = a;
            return salarylevel;
        }
        public double setbasicSalary()
        {
            do
            {
                Console.Write("Luong co ban:");
                basicSalary = double.Parse(Console.ReadLine());
            }
            while (basicSalary <= 0);
            return basicSalary;
        }
        public double getIncome()
        {
            return salarylevel * basicSalary;
        }
        public void nhap()
        {
            int x;
            double y;
            getname();
            do
            {
                Console.Write("Nam sinh:");
                x = int.Parse(Console.ReadLine());
            }
            while (x > 2001);
            getyearofbirth(x);
            do
            {
                Console.Write("Bac luong:");
                y = double.Parse(Console.ReadLine());
            }
            while (y <= 0);
            setSalarylevel(y);
            getIncome();
        }
        public void display(int i)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", id, name, yearofbirth, basicSalary);
        }
    }
    class DSNLD
    {
        int n;
        Employee[] ds;
        Employee l = new Employee();
        public void Nhap()
        {
            l.setbasicSalary();
            do
            {
                Console.Write("Nhap so nguoi lao dong:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);
            ds = new Employee[n];
            for (int i = 0; i < n; i++)
                ds[i] = new Employee();
            Console.WriteLine("Nhap thong tin nguoi lao dong:");
            for (int i = 0; i < n; i++)
                ds[i].nhap();
        }
        public void hienthi()
        {
            Console.WriteLine("ID\tTen\tNam sinh\tLuong co ban\tThu nhap");
            for(int i=0;i<n;i++)
            {
                ds[i].getid(i + 1);
                ds[i].display(i);
            }
        }
    }
    class App
    { 
        static void Main(string[] args)
        {
            DSNLD k = new DSNLD();
            k.Nhap();
            k.hienthi();
            Console.ReadKey();
        }
    }
}
