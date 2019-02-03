
namespace NoSlang.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Junk : ProcessModel
    {
        private readonly Dictionary<char, string> _symbols = new Dictionary<char, string>
        {
            ['1'] = "\u3105", //
            ['q'] = "\u3106",
            ['a'] = "\u3107",
            ['z'] = "\u3108",
            ['2'] = "\u3109",
            ['w'] = "\u310a",
            ['s'] = "\u310b",
            ['x'] = "\u310c",
            ['e'] = "\u310d",
            ['d'] = "\u310e",
            ['c'] = "\u310f",
            ['r'] = "\u3110",
            ['f'] = "\u3111",
            ['v'] = "\u3112",
            ['5'] = "\u3113",
            ['t'] = "\u3114",
            ['g'] = "\u3115",
            ['b'] = "\u3116",
            ['y'] = "\u3117",
            ['h'] = "\u3118",
            ['n'] = "\u3119",
            ['8'] = "\u311a",
            ['i'] = "\u311b",
            ['k'] = "\u311c",
            [','] = "\u311d",
            ['9'] = "\u311e",
            ['o'] = "\u311f",
            ['l'] = "\u3120",
            ['.'] = "\u3121",
            ['0'] = "\u3122",
            ['p'] = "\u3123",
            [';'] = "\u3124",
            ['/'] = "\u3125",
            ['-'] = "\u3126",
            ['u'] = "\u3127",
            ['j'] = "\u3128",
            ['m'] = "\u3129",
        };

        private readonly Dictionary<char,string> _tone = new Dictionary<char, string>
        {
            ['3'] = "\u02c7",
            ['4'] = "\u02cb",
            ['6'] = "\u02ca",
            ['7'] = "\u02d9",
            [' '] = "\u02c9"
        };

        internal protected override bool TryParse(string abracadabra, out string result)
        {
            var sb = new StringBuilder(abracadabra.Length);
            for (var i = 0; i < abracadabra.Length; i++)
            {
                var c = abracadabra[i];
                if (this._symbols.TryGetValue(c, out var v) || this._tone.TryGetValue(c, out v))
                {
                    sb.Append(v);
                }
                else
                    sb.Append(c);
            }

            result = sb.ToString();
            return true;
        }
        
    }
}
