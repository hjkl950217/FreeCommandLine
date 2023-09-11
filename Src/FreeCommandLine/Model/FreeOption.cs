namespace FreeCommandLine.Model
{
    public class FreeOption : NodeBase
    {
        public FreeOption()
            : base(NodeType.Option)
        {
        }

        public string LongName { get; set; }
        public string ShortName { get; private set; }
        public string Group { get; set; }
    }
}