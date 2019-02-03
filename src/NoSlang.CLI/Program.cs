using NoSlang.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NoSlang.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Parser.From("JI3U/6AJ4D9 5K7", new Junk()).Value);
            //throw new NotImplementedException();
            Console.ReadKey();
        }
    }
}
