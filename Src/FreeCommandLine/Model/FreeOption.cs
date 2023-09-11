namespace FreeCommandLine.Model
{
    public class FreeOption : NodeBase
    {
        public FreeOption()
            : base(NodeType.Option)
        {
            this.ValueArray = Array.Empty<FreeValue>();
        }

        public string LongName { get; set; }
        public string ShortName { get; private set; }
        public string Group { get; set; }

        public FreeValue[] ValueArray { get; set; }
    }
}