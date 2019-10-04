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
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.X:
                        timer -= 500;
                        break;
                    case ConsoleKey.Z:
                        timer += 500;
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

                timer = timer <= 0 ? 100 : timer;
            }
        }
    }
}

