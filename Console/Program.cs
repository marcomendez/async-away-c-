using MyCustomLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static async void Main(string[] args)
        {
            var textList = ReaderFile.ReadFile("E:\\test01.txt");

            foreach (string item in textList)
            {
               Console.Wril. item + " with delay " + time;
                await Task.Delay(time);
            }
        }
    }
}
