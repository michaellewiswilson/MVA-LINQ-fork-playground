using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ayy! we're only loaing up the first 3, cool
            var strings = GeneratedStrings().Take(3);  

            // This doesn't change (yet):
            foreach (var item in strings)  
                Console.WriteLine(item);

            Console.ReadLine();
        }

        // Core syntax for an enumerable:
        private static IEnumerable<string> GeneratedStrings()
        {
            yield return "one";
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
        }
    }
}
