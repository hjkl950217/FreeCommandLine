namespace FreeCommandLine.Model
{
    /// <summary>
    /// 节点基类
    /// </summary>
    public abstract class NodeBase
    {
        public string Name { get; set; }
        public string HelpText { get; set; }

        /// <summary>
        /// 标记类型
        /// </summary>
        public NodeType NodeType { get; }

        protected NodeBase(NodeType nodeType)
        {
            this.NodeType = nodeType;
        }
    }
}