``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2364/21H1/May2021Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2


```
|               Method |      Mean |     Error |    StdDev |    Median | Rank | Allocated |
|--------------------- |----------:|----------:|----------:|----------:|-----:|----------:|
| YechielWayCastSimple | 0.1892 ns | 0.1066 ns | 0.3145 ns | 0.0000 ns |    1 |         - |
|       FelixWayCastTo | 0.3103 ns | 0.0792 ns | 0.2261 ns | 0.2659 ns |    2 |         - |
