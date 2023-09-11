using FreeCommandLine.Attr;
using FreeCommandLine.Model;

namespace FreeCommandLine.ConsoleTest
{
    [GlobalOpt]
    [HelpText("这是一个测试命令")]
    public class TestGlobalOpt
    {
        [Opt("h", "host")]
        public string Host { get; set; }
    }

    [Command("file", "f")]
    [HelpText("这是一个测试命令")]
    public class TestCommand
    {
        [Opt("num", "n")]
        [HelpText("这是一个测试命令")]
        [Usage("测试时", Example = "10")]
        public int? Num { get; set; }

        /*
         *
         * [用法]
         * 测试时:
         * file -n 10
         */

        [Value(index: 0)]
        public string? Url { get; set; }

        public void ShowTestInfo(GlobalOpt<TestGlobalOpt> gopt)
        {
            Console.WriteLine($"调用了test命令,获取到的选项是:[{this.Num}],获取到的Url值为:[{this.Url}]");
        }
    }
}