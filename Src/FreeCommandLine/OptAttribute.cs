namespace FreeCommandLine
{
    /// <summary>
    /// 选项
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false, Inherited = true)]
    public class OptAttribute : ModelBaseAttr
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Group { get; set; }

        private OptAttribute(
            string shortName,
            string longName,
            string group,
            bool isRequired = false,
            string? helpText = null)
            : base(isRequired)
        {
            this.ShortName = shortName;
            this.LongName = longName;
            this.Group = group;

            this.Required = isRequired;
            this.HelpText = helpText ?? string.Empty;
        }

        public OptAttribute()
           : this(string.Empty, string.Empty, string.Empty)
        {
        }

        public OptAttribute(string shortName)
            : this(shortName, string.Empty, string.Empty)
        {
        }

        public OptAttribute(string shortName, string longName)
           : this(shortName, longName, string.Empty)
        {
        }
    }
}