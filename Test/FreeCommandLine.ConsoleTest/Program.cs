namespace FreeCommandLine.ConsoleTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string warning = "warn";
            string error = "error";

            int paddingAmount = 10;

            ShowInfo(warning, paddingAmount);
            ShowInfo(error, paddingAmount);

            //var table = new ConsoleTable("one", "two", "three");
            //table.AddRow(1, 2, 3)
            //     .AddRow("this line should be longer", "yes it is", "oh");
            //// 打印
            //table.Write();

            Console.WriteLine("==================");

            IReadOnlyDictionary<string, Delegate> deleDic = ExpHelper.ResoleToProp(typeof(TestGlobalOpt));
            Delegate deleA = deleDic[nameof(TestGlobalOpt.Host)];

            TestGlobalOpt testOpt = new TestGlobalOpt();
            deleA.DynamicInvoke(testOpt, "123");
            Console.WriteLine(testOpt.Host);
            Console.ReadLine();
        }

        public static void ShowInfo(string str, int lenght)
        {
            Console.WriteLine($"[{str.PadLeft(lenght)}]");
        }
    }
}