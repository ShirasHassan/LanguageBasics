using System;

namespace DotNet
{
    internal class StringExtensions
    {
        /// <summary>
        ///   String methods 
        /// </summary>
        /// <param name="statements"></param>
        internal static void Sample(string statements)
        {
            Console.WriteLine($"String Length :{statements.Length}");
            Console.WriteLine($"String Substring(0,5) :{statements.Substring(0,5)}");
            Console.WriteLine($"String Index of `o` :{statements.IndexOf('o')}");
            Console.WriteLine($"String 2nd Index of `o` after 4th index :{statements.IndexOf('o',5)}");
            Console.WriteLine($"String 2nd Index of `o` after 4th index but search next 2 character only :{statements.IndexOf('o',5,2)}");
            Console.WriteLine($"String Contains `Hello` :{statements.Contains("Hello")}");
            Console.WriteLine($"String ToUpper Hello:{statements.ToUpper()}");
            Console.WriteLine($"String Index[0] of Hello:{statements[0]}");
            for (var i = statements.Length; i >0 ; i--)
            {
                Console.Write(statements[i-1]);
            }
        }
    }
}