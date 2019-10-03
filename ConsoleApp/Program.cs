using MyCustomLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static int time = 1000;

        static void Main(string[] args)
        {
            Task taskShowInfoFromFile = ShowInfo(ReaderFile.ReadFile("E:\\test01.txt"));
            MyCustomEvent.InputKeys(ref time);
        }
        private static async Task ShowInfo(IEnumerable<string> listText)
        {
            foreach (string newLine in listText)
            {
                Console.WriteLine($"{newLine} with delay  {(time / 1000).ToString()}");
                await Task.Delay(time);
            }
        }
      
    }
}
