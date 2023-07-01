using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введите целое число");

        int integernumber = int.Parse(Console.ReadLine());
        
        if (integernumber % 2 == 0)
        {
            Console.WriteLine("Целое число");
        }
        else
        {
            Console.WriteLine("Нецелое число");

        }
        Console.ReadKey();
    }
}
