using MyCustomLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static int timer = 1000;
        static bool isPause = false;
        static void Main(string[] args)
        {
            Task taskShowInfoFromFile = ShowInfo(ReaderFile.ReadFile("E:\\quotes.txt"));
            MyCustomEvent.KeyPress(ref timer, ref isPause);
        }
        private static async Task ShowInfo(IEnumerable<string> listText)
        {
          
            foreach (string newLine in listText)
            {
                Console.WriteLine($"{newLine} with delay  {(timer / 1000).ToString()}");
                while(isPause)
                {
                    Console.WriteLine("I am paused");
                    await Task.Delay(1000);
                }
                await Task.Delay(timer);
            }
        }
    }
}
