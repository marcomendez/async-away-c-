using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyCustomLibrary
{
    public class ReaderFile
    {
        public static IEnumerable<string> ReadFile(string pathFile)
        {
            var sr = File.OpenText(pathFile);
            
            while (!sr.EndOfStream)
            {
                yield return sr.ReadLine();
                
            }
            
        }
    }
}
