namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 帮助文本
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = false)]
    public class HelpTextAttribute : ModelBaseAttr
    {
        public string Text { get; protected set; }

        public HelpTextAttribute(string text)
            : base(false)
        {
            text.ThrowIfNull();

            Text = text;
        }
    }
}