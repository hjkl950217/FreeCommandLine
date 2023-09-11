using System.Diagnostics.CodeAnalysis;

namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 标记当前类是一个命令
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Method,
        AllowMultiple = false,
        Inherited = true)]
    public class CommandAttribute : ModelBaseAttr
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="name">命令名称</param>
        /// <param name="aliases">别名组</param>
        public CommandAttribute(
            [NotNull] string name,
            params string[]? aliases)
            : base(true)
        {
            name.ThrowIfNull();

            this.Aliases = aliases ?? Array.Empty<string>();
            this.CommandName = name;
        }

        /// <summary>
        /// 配置的本身命令
        /// </summary>
        public string CommandName { get; protected set; }

        /// <summary>
        /// 别名
        /// </summary>
        public string[] Aliases { get; protected set; }
    }
}