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
        static async Task Main(string[] args)
        {

            ShowOption();

            var option = Console.ReadKey(true).Key;

            Console.WriteLine(" ");

            switch (option)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(ReaderFile.ReadAll("C:\\quotes.txt"));
                    break;

                case ConsoleKey.D2:
                    Task showLineByLine = ShowLineByLine(ReaderFile.ReadFile("C:\\quotes.txt"));
                    MyCustomEvent.KeyPress(ref timer, ref isPause);
                    break;

                case ConsoleKey.D3:
                    Task showWordByWord =  ShowWordByWord();
                    MyCustomEvent.KeyPress(ref timer, ref isPause);
                    break;
            }
            Console.ReadKey();

        }

        public static void ShowOption()
        {
            Console.WriteLine("Choose one option");
            Console.WriteLine(" 1.	Desplegarlo en la pantalla \n 2.	Desplegarlo en la pantalla línea por línea \n 3.	Desplegarlo en la pantalla palabra por palabra");

        }

        private static async Task ShowWordByWord ()
        {
            foreach (string newLine in ReaderFile.ReadFile("C:\\quotes.txt"))
            {
                foreach (string word in newLine.Split(' '))
                {
                    await Pause();
                    Console.Write(word + " ");
                    await Task.Delay(timer);

                }
                Console.WriteLine("");

            }
        }
        private static async Task ShowLineByLine(IEnumerable<string> listText)
        {
            foreach (string newLine in listText)
            {
                Console.WriteLine(newLine);
                await Pause();
                await Task.Delay(timer);
            }
        }

        private static async Task Pause()
        {
            while (isPause)
            {
                await Task.Delay(1000);
            }
        }

        
    }
}
