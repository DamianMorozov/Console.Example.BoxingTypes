// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Example.BoxingTypes
{
    [SimpleJob(RuntimeMoniker.Net50)]
    [MemoryDiagnoser]
    public class Boxing
    {
        [Benchmark]
        public int MethodNoBoxing()
        {
            int res = 0;
            int a = 1;
            res += a;
            return res;
        }
        
        [Benchmark]
        public int MethodBoxing()
        {
            int res = 0;
            object a = 1;
            res += (int)a;
            return res;
        }
    }
}
