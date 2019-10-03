using System;
using static System.Net.Mime.MediaTypeNames;

namespace MyCustomLibrary
{
    public class MyCustomEvent
    {
        public static void InputKeys(ref int timer)
        {
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        timer += 1000;
                        break;
                    case ConsoleKey.B:
                        timer -= 1000;
                        break;
                    case ConsoleKey.X:
                        flag = false;
                        break;
                }
                timer = timer <= 0 ? 1000 : timer;
                Console.WriteLine($"Timer updated to {timer / 1000} seconds");
            }
        }
    }
}

