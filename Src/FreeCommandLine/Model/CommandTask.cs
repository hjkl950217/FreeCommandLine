namespace FreeCommandLine.Model
{
    public abstract class CommandTask
    {
        public abstract void Run(CommandContext ctx);
    }

    /// <summary>
    /// 代表命令的基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CommandTask<T> : CommandTask
        where T : class, new()
    {
        public abstract void Run(T gOpt, CommandContext ctx);

        public override void Run(CommandContext ctx)
        {
            this.Run(new T(), ctx);
        }
    }
}