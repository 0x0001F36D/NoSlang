// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace NoSlang
{
    public sealed class ParsedResult
    {
        public string Language { get; }

        public string Value { get; }

        internal ParsedResult(string value, string language)
        {
            this.Value = value;
            this.Language = language;
        }
    }
}