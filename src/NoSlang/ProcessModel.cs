// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace NoSlang
{
    public abstract class ProcessModel
    {
        public virtual string Language => this.GetType().Name;

        protected internal abstract bool TryParse(string abracadabra, out string result);
    }
}