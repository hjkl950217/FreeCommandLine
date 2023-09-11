namespace FreeCommandLine.Model
{
    public class FreeValue : NodeBase
    {
        public FreeValue()
            : base(NodeType.Value)
        {
        }

        public byte Index { get; set; }
        public object Value { get; set; }
    }
}