// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using BenchmarkDotNet.Running;

namespace Example.BoxingTypes
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Boxing and unboxing of data types.");
            Console.WriteLine("BenchmarkRunner.Run<Boxing>();");
            BenchmarkRunner.Run<Boxing>();

            Console.WriteLine();
            Console.WriteLine("BenchmarkRunner.Run<Md5VsSha256>();");
            BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}
