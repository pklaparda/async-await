``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2364/21H1/May2021Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2


```
|               Method |     Mean |    Error |   StdDev |   Median | Rank | Allocated |
|--------------------- |---------:|---------:|---------:|---------:|-----:|----------:|
|    ValidateWithRegex | 21.42 ns | 0.622 ns | 1.774 ns | 20.87 ns |    1 |         - |
| ValidateWithTryParse | 98.06 ns | 2.852 ns | 8.183 ns | 96.34 ns |    2 |         - |
