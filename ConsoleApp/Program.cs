using MyCustomLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static int timer = 1000;
        static void Main(string[] args)
        {
            Task taskShowInfoFromFile = ShowInfo(ReaderFile.ReadFile("E:\\test01.txt"));
            MyCustomEvent.KeyPress(ref timer);
        }
        private static async Task ShowInfo(IEnumerable<string> listText)
        {
            foreach (string newLine in listText)
            {
                Console.WriteLine($"{newLine} with delay  {(timer / 1000).ToString()}");
                await Task.Delay(timer);
            }
        }
    }
}
