namespace FreeCommandLine.Model
{
    public class FreeValue : NodeBase
    {
        public FreeValue()
            : base(NodeType.Value)
        {
        }

        /// <summary>
        /// 索引顺序，默认和无序时为0
        /// </summary>
        public byte Index { get; set; }

        /// <summary>
        /// 输入的值
        /// </summary>
        public object Value { get; set; }
    }
}