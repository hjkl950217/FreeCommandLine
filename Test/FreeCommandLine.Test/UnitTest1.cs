namespace FreeCommandLine.Test
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            string? str = null;

            str.ThrowIfNull();
        }
    }
}