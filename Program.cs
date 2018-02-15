using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace AttributesDemo
{
    class Program
    {
        [Obsolete("outDated Method")]
        public void show()
        {
            Console.WriteLine("Method called");
        }
        //static void Main(string[] args)
        //{
        //    Program p1 = new Program();
        //    p1.show();
        //}
    }
}
