namespace FreeCommandLine
{
    /// <summary>
    /// 谓词
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = true)]
    public class VerbAttribute : Attribute
    {
        public VerbAttribute(
            string name,
            string? helpText = null,
            string[]? aliases = null)
        {
            name.ThrowIfNull();

            this.Name = name;
            this.HelpText = helpText ?? string.Empty;
            this.Aliases = aliases ?? Array.Empty<string>();
        }

        public string Name { get; set; }

        public string HelpText { get; set; }
        public Type? ResourceType { get; set; }

        public string[] Aliases { get; set; }
    }
}