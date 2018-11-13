using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OneDimArray oneDimArray = new OneDimArray(2);
            oneDimArray[0] = 5;
            Console.WriteLine(oneDimArray[0]);
            Console.ReadLine();
        }
    }
}
