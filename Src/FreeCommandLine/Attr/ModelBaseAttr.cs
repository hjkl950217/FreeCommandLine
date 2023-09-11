namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 定义模型的基础特性
    /// </summary>
    public abstract class ModelBaseAttr : Attribute
    {
        public bool Required { get; protected set; }
        public Type? ResourceType { get; protected set; }

        public ModelBaseAttr(
            bool required)
        {
            this.Required = required;
            this.ResourceType = null;
        }
    }
}