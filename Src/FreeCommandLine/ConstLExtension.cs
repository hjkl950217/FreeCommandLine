namespace FreeCommandLine
{
    public static class ConstLExtension
    {
        /// <summary>
        /// 如果为null则抛出异常。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ThrowIfNull(
            this object? value,
            [CallArg(nameof(value))] string argName = "")
        {
            if(value == null)
            {
                throw new ArgumentException(string.Format(ConstL.NotCanBeNull, argName));
            }
        }
    }
}