using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of  Hest
            Hest minHest = new Hest();
            Hest minAndenHest = new Hest();
            //test
            minHest.Run();
            minAndenHest.Run();
        }
    }
}