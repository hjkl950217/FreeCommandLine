namespace FreeCommandLine.ConsoleTest
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string warning = "warn";
            string error = "error";

            int paddingAmount = 10;

            ShowInfo(warning, paddingAmount);
            ShowInfo(error, paddingAmount);

            Console.ReadLine();

            //var table = new ConsoleTable("one", "two", "three");
            //table.AddRow(1, 2, 3)
            //     .AddRow("this line should be longer", "yes it is", "oh");
            //// 打印
            //table.Write();
        }

        public static void ShowInfo(string str, int lenght)
        {
            Console.WriteLine($"[{str.PadLeft(lenght)}]");
        }
    }
}