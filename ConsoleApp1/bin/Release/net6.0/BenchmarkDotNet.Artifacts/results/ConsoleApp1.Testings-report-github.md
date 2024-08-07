``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2364/21H1/May2021Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.12 (6.0.1222.56807), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.12 (6.0.1222.56807), X64 RyuJIT AVX2


```
|           Method |       Mean |     Error |    StdDev |     Median | Rank |   Gen0 | Allocated |
|----------------- |-----------:|----------:|----------:|-----------:|-----:|-------:|----------:|
|     GetUrlStatic |  0.1124 ns | 0.0877 ns | 0.1258 ns |  0.0615 ns |    1 |      - |         - |
| GetUrlDictionary | 24.7831 ns | 0.5956 ns | 0.5280 ns | 24.6895 ns |    2 | 0.0114 |      48 B |
|           GetUrl | 31.3254 ns | 0.8032 ns | 2.2655 ns | 30.4217 ns |    3 | 0.0114 |      48 B |
