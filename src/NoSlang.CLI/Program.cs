// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace NoSlang.CLI
{
    using NoSlang.Models;

    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //for debug
            Console.WriteLine(Parser.From("JI3U/6AJ4D9 5K7", new Bopomofo()).Value);
            //throw new NotImplementedException();
            Console.ReadKey();
        }
    }
}