using System;

namespace DotNet
{
  internal  class CharExtensions
    {
        /// <summary>
        ///  character methods
        /// </summary>
        /// <param name="statements"></param>
      internal  static void Sample(string statements)
        {
            decimal d =  0.00m;
            double u = 0.00d;
            float f = 00.00f;
            
            Console.WriteLine($"decimal d = 0.00m; {d}");
            Console.WriteLine($"double u = 0.00d;  {u}");
            Console.WriteLine($"float f = 00.00f;  {f}");
            
            Console.WriteLine($"ASCII A-Z: 65-90");
            Console.WriteLine($"ASCII a-z: 97-122");
            char[] arrays = statements.ToCharArray();
            for (var i = 0; i < statements.Length; i++)
            {
                Console.Write(arrays[i]);
                Console.Write($"[{(int) arrays[i]}]");
            }
        }
    }
}