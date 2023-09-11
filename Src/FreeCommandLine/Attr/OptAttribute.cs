namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 选项，使用时传递“(长名)-xxxx”或"(短名)-x"
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false, Inherited = true)]
    public class OptAttribute : ModelBaseAttr
    {
        public string LongName { get; set; }
        public string ShortName { get; private set; }
        public string Group { get; set; }

        public OptAttribute(
            string longName,
            string shortName)
            : base(false)
        {
            this.LongName = longName;
            this.ShortName = shortName;

            this.Group = string.Empty;
        }

        public OptAttribute(string shortName)
            : this(shortName, string.Empty)
        {
        }
    }
}