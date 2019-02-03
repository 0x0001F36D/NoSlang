
namespace NoSlang
{
    public abstract class ProcessModel
    {
        public virtual string Language => this.GetType().Name;
        internal protected abstract bool TryParse(string abracadabra, out string result);
    }
}
