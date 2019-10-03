using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCustomLibrary
{
    public class ShowInfo
    {
        public static async Task Show(IEnumerable<string> textList,int timer)
        {
            foreach (string item in textList)
            {
                Console.WriteLine($"{item} with delay  {(timer / 1000).ToString()} seconds.");
                await Task.Delay(timer);
            }
        }
    }
}
