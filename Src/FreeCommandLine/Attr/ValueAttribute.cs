namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 定义模型中传递的值，也就是参数。可能传递给谓词或选项
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = true)]
    public class ValueAttribute : ModelBaseAttr
    {
        public byte Index { get; }

        /// <summary>
        /// 标记属于那个选项
        /// </summary>
        public string OptFor { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="index"></param>
        public ValueAttribute(byte index = 0)
           : base(false)
        {
            this.Index = index;
            this.OptFor = string.Empty;
        }
    }
}