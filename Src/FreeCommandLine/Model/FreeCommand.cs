namespace FreeCommandLine.Model
{
    /// <summary>
    /// 代表命令的节点
    /// </summary>
    public class FreeCommand : NodeBase
    {
        public FreeCommand()
            : base(NodeType.Command)
        {
        }

        /// <summary>
        /// 别名
        /// </summary>
        public string[] Aliases { get; set; }
    }
}