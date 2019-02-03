namespace NoSlang
{
    public class ParseResult
    {

        internal ParseResult(string value, string language)
        {
            this.Value = value;
            this.Language = language;
        }

        public string Value { get; }
        public string Language { get; }
    }
}