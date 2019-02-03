// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace NoSlang
{
    public static class Parser
    {
        public static ParsedResult From(string abracadabra, ProcessModel processor)
        {
            if (processor.TryParse(abracadabra, out var result))
            {
                var r = new ParsedResult(result, processor.Language);
                return r;
            }
            return null;
        }
    }
}