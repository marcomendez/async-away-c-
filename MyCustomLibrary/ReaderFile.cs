using System.Collections.Generic;
using System.IO;

namespace MyCustomLibrary
{
    public class ReaderFile
    {
        public static IEnumerable<string> ReadFile(string pathFile)
        {
            var allText = File.OpenText(pathFile);
            while (!allText.EndOfStream)
            {
                yield return allText.ReadLine();
            }
        }
    }
}
