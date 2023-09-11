namespace FreeCommandLine.Attr
{
    /// <summary>
    /// 用法
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = true,
        Inherited = false)]
    public class UsageAttribute : ModelBaseAttr
    {
        /// <summary>
        /// 场景描述
        /// </summary>
        public string SceneText { get; protected set; }

        /// <summary>
        /// 示例值
        /// </summary>
        public string? Example { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="scene">场景描述</param>
        public UsageAttribute(string scene)
            : base(false)
        {
            scene.ThrowIfNull();

            this.SceneText = scene;
        }
    }
}