``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2364/21H1/May2021Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2


```
|               Method |     Mean |    Error |   StdDev | Rank |   Gen0 | Allocated |
|--------------------- |---------:|---------:|---------:|-----:|-------:|----------:|
| YechielWayNotANumber | 18.42 ns | 0.933 ns | 2.707 ns |    1 |      - |         - |
|    AdisWayNotANumber | 54.13 ns | 1.770 ns | 5.162 ns |    2 | 0.0076 |      32 B |
