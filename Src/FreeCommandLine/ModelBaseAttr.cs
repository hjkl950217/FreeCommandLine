namespace FreeCommandLine
{
    /// <summary>
    /// 定义模型的基础特性
    /// </summary>
    public abstract class ModelBaseAttr : Attribute
    {
        public bool Required { get; set; }
        public string HelpText { get; set; }
        public Type? ResourceType { get; set; }

        public ModelBaseAttr(
            bool required)
        {
            this.Required = required;
            this.HelpText = string.Empty;
            this.ResourceType = null;
        }
    }
}