using System.Dynamic;
using ConsoleTables;
using FreeCommandLine.Attr;
using FreeCommandLine.Model;
using ValueAttribute = FreeCommandLine.Attr.ValueAttribute;

namespace FreeCommandLine.ConsoleTest
{
    [GlobalOpt]
    [HelpText("这是一个测试命令")]
    public class TestGlobalOpt
    {
        [Opt("host", "h")]
        public string Host { get; set; }

        public int ABC { get; set; }
    }

    [Command("file", "f")]
    [HelpText("这是一个测试命令")]
    public class TestCommand
        : CommandTask<TestGlobalOpt>
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

        [Value(index: 0, OptFor = nameof(Num))]
        public string? Count { get; set; }

        public override void Run(
            TestGlobalOpt gOpt,
            CommandContext ctx)
        {
            dynamic aaa = new ExpandoObject();

            Console.WriteLine($"调用了 file 命令,获取到的选项是:[{this.Num}],获取到的Url值为:[{this.Count}]");

            ConsoleTable table = new("命令或参数", "说明");
            table.AddRow("file", "调用了file命令")
                .AddRow($"{nameof(TestGlobalOpt.Host)}", gOpt.Host)
                .AddRow($"{nameof(this.Num)}", this.Num)
                .AddRow($"{nameof(this.Count)}", this.Count);

            // 打印
            table.Write();
        }
    }
}