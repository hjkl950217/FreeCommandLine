namespace FreeCommandLine
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
        public byte Index { get; set; }

        public ValueAttribute(byte index)
            : base(false)
        {
            this.Index = index;
        }
    }
}