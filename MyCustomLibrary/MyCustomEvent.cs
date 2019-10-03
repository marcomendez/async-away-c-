using System;

namespace MyCustomLibrary
{
    public class MyCustomEvent
    {
        public static void KeyPress(ref int timer, ref bool isPaused)
        {
            bool flag = true;
            while (flag)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.X:
                        timer += 1000;
                        break;
                    case ConsoleKey.Z:
                        timer -= 1000;
                        break;
                    case ConsoleKey.P:
                        isPaused = isPaused == true ? false : true;
                        break;
                    case ConsoleKey.K:
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

