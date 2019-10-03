using System;

namespace MyCustomLibrary
{
    public class MyCustomEvent
    {
        public static void KeyPress(ref int timer)
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
                    default:
                        Console.WriteLine(" Key inconect, Please use 'A' to increse and 'B' to desincrese.");
                        break;
                }
                timer = timer <= 0 ? 1000 : timer;
                Console.WriteLine($" Timer updated to {timer / 1000} seconds");
            }
        }
    }
}

