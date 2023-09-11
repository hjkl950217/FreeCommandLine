namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 标记当前方法是命令的执行方法
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = false)]
    public class GlobalOptAttribute : ModelBaseAttr
    {
        /// <summary>
        ///
        /// </summary>
        public GlobalOptAttribute()
            : base(true)
        {
        }
    }
}