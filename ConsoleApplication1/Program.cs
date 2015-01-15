using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stu stu = new Stu();
            stu.Id = 1;
            Console.WriteLine(stu.Id);
            Console.Read();
        }
    }
}
