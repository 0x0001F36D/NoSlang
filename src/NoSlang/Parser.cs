
namespace NoSlang
{
    using System;

    public static class Parser
    {
        public static ParseResult From(string abracadabra, ProcessModel processor)
        {
            if (processor.TryParse(abracadabra, out var result))
            {
                var r = new ParseResult(result, processor.Language);
                return r;
            }
            return null;
        }
    }
}
