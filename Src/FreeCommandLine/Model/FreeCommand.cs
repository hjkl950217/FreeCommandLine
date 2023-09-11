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
            this.ChildCommand = Array.Empty<FreeCommand>();
            this.OptionArray = Array.Empty<FreeOption>();
            this.ValueArray = Array.Empty<FreeValue>();
        }

        /// <summary>
        /// 别名
        /// </summary>
        public string[] Aliases { get; set; }

        public FreeCommand[] ChildCommand { get; set; }
        public FreeOption[] OptionArray { get; set; }
        public FreeValue[] ValueArray { get; set; }
    }
}