```

BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3693/22H2/2022Update)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method                                      | Job      | Runtime  | Size  | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0      | Gen1      | Gen2     | Allocated  | Alloc Ratio |
|-------------------------------------------- |--------- |--------- |------ |-----------:|----------:|----------:|------:|--------:|----------:|----------:|---------:|-----------:|------------:|
| **GetAsync_ReadAsStringAsync**                  | **.NET 6.0** | **.NET 6.0** | **10**    |   **106.0 μs** |   **1.60 μs** |   **1.33 μs** |  **1.00** |    **0.00** |    **1.4648** |         **-** |        **-** |     **6.1 KB** |        **1.00** |
| GetAsync_ReadAsStreamAsync                  | .NET 6.0 | .NET 6.0 | 10    |   103.2 μs |   1.81 μs |   1.69 μs |  0.98 |    0.02 |    0.9766 |         - |        - |    4.39 KB |        0.72 |
| GetAsync_ReadFromJsonAsync                  | .NET 6.0 | .NET 6.0 | 10    |   103.9 μs |   0.79 μs |   0.70 μs |  0.98 |    0.02 |    1.0986 |         - |        - |    4.77 KB |        0.78 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10    |   102.7 μs |   0.63 μs |   0.49 μs |  0.97 |    0.01 |    1.4648 |         - |        - |     6.1 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10    |   102.3 μs |   2.03 μs |   2.50 μs |  0.97 |    0.02 |    0.8545 |         - |        - |    3.48 KB |        0.57 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10    |   102.1 μs |   0.53 μs |   0.50 μs |  0.96 |    0.01 |    0.7324 |         - |        - |    3.86 KB |        0.63 |
| GetStreamAsync                              | .NET 6.0 | .NET 6.0 | 10    |   100.2 μs |   0.77 μs |   0.64 μs |  0.94 |    0.01 |    0.7324 |         - |        - |    3.39 KB |        0.56 |
| GetStringAsync                              | .NET 6.0 | .NET 6.0 | 10    |   102.4 μs |   1.08 μs |   0.96 μs |  0.97 |    0.01 |    1.2207 |         - |        - |    5.24 KB |        0.86 |
| GetFromJsonAsync                            | .NET 6.0 | .NET 6.0 | 10    |   104.3 μs |   1.08 μs |   0.95 μs |  0.98 |    0.01 |    0.9766 |         - |        - |    4.92 KB |        0.81 |
| GetAsync_ReadAsStringAsync                  | .NET 7.0 | .NET 7.0 | 10    |   116.5 μs |   0.80 μs |   0.75 μs |  1.10 |    0.01 |    1.4648 |         - |        - |    5.85 KB |        0.96 |
| GetAsync_ReadAsStreamAsync                  | .NET 7.0 | .NET 7.0 | 10    |   115.3 μs |   0.66 μs |   0.55 μs |  1.09 |    0.01 |    0.9766 |         - |        - |    4.16 KB |        0.68 |
| GetAsync_ReadFromJsonAsync                  | .NET 7.0 | .NET 7.0 | 10    |   117.5 μs |   1.28 μs |   1.13 μs |  1.11 |    0.02 |    0.9766 |         - |        - |    4.52 KB |        0.74 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10    |   119.4 μs |   2.31 μs |   3.24 μs |  1.13 |    0.04 |    1.4648 |         - |        - |    5.85 KB |        0.96 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10    |   113.9 μs |   0.75 μs |   0.70 μs |  1.07 |    0.02 |    0.7324 |         - |        - |    3.24 KB |        0.53 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10    |   116.0 μs |   2.14 μs |   2.10 μs |  1.10 |    0.03 |    0.7324 |         - |        - |    3.61 KB |        0.59 |
| GetStreamAsync                              | .NET 7.0 | .NET 7.0 | 10    |   113.8 μs |   0.83 μs |   0.73 μs |  1.07 |    0.01 |    0.7324 |         - |        - |    3.16 KB |        0.52 |
| GetStringAsync                              | .NET 7.0 | .NET 7.0 | 10    |   115.5 μs |   0.83 μs |   0.69 μs |  1.09 |    0.02 |    1.2207 |         - |        - |    4.99 KB |        0.82 |
| GetFromJsonAsync                            | .NET 7.0 | .NET 7.0 | 10    |   119.6 μs |   2.29 μs |   2.98 μs |  1.14 |    0.03 |    0.9766 |         - |        - |    4.67 KB |        0.77 |
| GetAsync_ReadAsStringAsync                  | .NET 8.0 | .NET 8.0 | 10    |   110.7 μs |   0.86 μs |   0.76 μs |  1.04 |    0.02 |    1.2207 |         - |        - |    5.67 KB |        0.93 |
| GetAsync_ReadAsStreamAsync                  | .NET 8.0 | .NET 8.0 | 10    |   109.7 μs |   1.28 μs |   1.13 μs |  1.03 |    0.02 |    0.9766 |         - |        - |    3.97 KB |        0.65 |
| GetAsync_ReadFromJsonAsync                  | .NET 8.0 | .NET 8.0 | 10    |   111.4 μs |   0.90 μs |   0.84 μs |  1.05 |    0.01 |    0.9766 |         - |        - |    4.27 KB |        0.70 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10    |   110.5 μs |   0.84 μs |   0.75 μs |  1.04 |    0.01 |    1.2207 |         - |        - |    5.67 KB |        0.93 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10    |   111.9 μs |   0.82 μs |   0.73 μs |  1.05 |    0.02 |    0.7324 |         - |        - |    3.05 KB |        0.50 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10    |   109.5 μs |   0.49 μs |   0.38 μs |  1.03 |    0.01 |    0.7324 |         - |        - |    3.35 KB |        0.55 |
| GetStreamAsync                              | .NET 8.0 | .NET 8.0 | 10    |   112.7 μs |   0.76 μs |   0.67 μs |  1.06 |    0.01 |    0.7324 |         - |        - |    2.97 KB |        0.49 |
| GetStringAsync                              | .NET 8.0 | .NET 8.0 | 10    |   110.3 μs |   1.20 μs |   1.00 μs |  1.04 |    0.02 |    0.9766 |         - |        - |     4.8 KB |        0.79 |
| GetFromJsonAsync                            | .NET 8.0 | .NET 8.0 | 10    |   110.5 μs |   0.85 μs |   0.79 μs |  1.04 |    0.01 |    0.7324 |         - |        - |    3.72 KB |        0.61 |
|                                             |          |          |       |            |           |           |       |         |           |           |          |            |             |
| **GetAsync_ReadAsStringAsync**                  | **.NET 6.0** | **.NET 6.0** | **100**   |   **184.0 μs** |   **1.44 μs** |   **1.20 μs** |  **1.00** |    **0.00** |    **8.7891** |         **-** |        **-** |   **35.82 KB** |        **1.00** |
| GetAsync_ReadAsStreamAsync                  | .NET 6.0 | .NET 6.0 | 100   |   182.5 μs |   1.99 μs |   1.66 μs |  0.99 |    0.01 |    4.8828 |         - |        - |   20.55 KB |        0.57 |
| GetAsync_ReadFromJsonAsync                  | .NET 6.0 | .NET 6.0 | 100   |   184.4 μs |   1.30 μs |   1.08 μs |  1.00 |    0.01 |    5.1270 |         - |        - |   20.93 KB |        0.58 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 100   |   186.0 μs |   3.52 μs |   3.76 μs |  1.02 |    0.02 |    8.7891 |         - |        - |   35.83 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 100   |   179.1 μs |   0.41 μs |   0.32 μs |  0.97 |    0.01 |    1.9531 |         - |        - |    8.81 KB |        0.25 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 100   |   180.3 μs |   1.26 μs |   1.05 μs |  0.98 |    0.01 |    2.1973 |         - |        - |     9.2 KB |        0.26 |
| GetStreamAsync                              | .NET 6.0 | .NET 6.0 | 100   |   180.5 μs |   3.59 μs |   3.18 μs |  0.98 |    0.02 |    1.9531 |         - |        - |    8.73 KB |        0.24 |
| GetStringAsync                              | .NET 6.0 | .NET 6.0 | 100   |   181.0 μs |   0.82 μs |   0.73 μs |  0.98 |    0.01 |    5.8594 |         - |        - |   24.14 KB |        0.67 |
| GetFromJsonAsync                            | .NET 6.0 | .NET 6.0 | 100   |   184.2 μs |   0.80 μs |   0.71 μs |  1.00 |    0.01 |    5.1270 |    0.2441 |        - |   21.08 KB |        0.59 |
| GetAsync_ReadAsStringAsync                  | .NET 7.0 | .NET 7.0 | 100   |   197.1 μs |   1.44 μs |   1.13 μs |  1.07 |    0.01 |    8.5449 |    0.2441 |        - |   35.57 KB |        0.99 |
| GetAsync_ReadAsStreamAsync                  | .NET 7.0 | .NET 7.0 | 100   |   193.7 μs |   1.00 μs |   0.89 μs |  1.05 |    0.01 |    4.8828 |         - |        - |   20.31 KB |        0.57 |
| GetAsync_ReadFromJsonAsync                  | .NET 7.0 | .NET 7.0 | 100   |   196.1 μs |   1.47 μs |   1.30 μs |  1.07 |    0.01 |    5.1270 |         - |        - |   20.68 KB |        0.58 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 100   |   198.0 μs |   3.78 μs |   3.54 μs |  1.08 |    0.02 |    8.5449 |         - |        - |   35.57 KB |        0.99 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 100   |   190.3 μs |   0.52 μs |   0.44 μs |  1.03 |    0.01 |    1.9531 |         - |        - |    8.58 KB |        0.24 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 100   |   192.9 μs |   1.17 μs |   1.09 μs |  1.05 |    0.01 |    2.1973 |         - |        - |    8.95 KB |        0.25 |
| GetStreamAsync                              | .NET 7.0 | .NET 7.0 | 100   |   190.1 μs |   1.01 μs |   0.84 μs |  1.03 |    0.01 |    1.9531 |         - |        - |    8.49 KB |        0.24 |
| GetStringAsync                              | .NET 7.0 | .NET 7.0 | 100   |   196.4 μs |   2.88 μs |   3.74 μs |  1.07 |    0.02 |    5.8594 |         - |        - |   23.89 KB |        0.67 |
| GetFromJsonAsync                            | .NET 7.0 | .NET 7.0 | 100   |   196.1 μs |   0.54 μs |   0.48 μs |  1.07 |    0.01 |    5.1270 |         - |        - |   20.83 KB |        0.58 |
| GetAsync_ReadAsStringAsync                  | .NET 8.0 | .NET 8.0 | 100   |   180.8 μs |   1.09 μs |   0.91 μs |  0.98 |    0.01 |    8.3008 |         - |        - |   35.39 KB |        0.99 |
| GetAsync_ReadAsStreamAsync                  | .NET 8.0 | .NET 8.0 | 100   |   178.2 μs |   1.55 μs |   1.38 μs |  0.97 |    0.01 |    4.8828 |         - |        - |   20.13 KB |        0.56 |
| GetAsync_ReadFromJsonAsync                  | .NET 8.0 | .NET 8.0 | 100   |   179.7 μs |   2.89 μs |   3.95 μs |  0.98 |    0.03 |    4.8828 |         - |        - |   20.42 KB |        0.57 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 100   |   179.6 μs |   0.97 μs |   0.81 μs |  0.98 |    0.01 |    8.3008 |         - |        - |   35.39 KB |        0.99 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 100   |   174.9 μs |   0.97 μs |   0.86 μs |  0.95 |    0.01 |    1.9531 |         - |        - |    8.39 KB |        0.23 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 100   |   177.4 μs |   1.20 μs |   1.00 μs |  0.96 |    0.01 |    1.9531 |         - |        - |    8.69 KB |        0.24 |
| GetStreamAsync                              | .NET 8.0 | .NET 8.0 | 100   |   174.9 μs |   1.13 μs |   1.00 μs |  0.95 |    0.01 |    1.9531 |         - |        - |     8.3 KB |        0.23 |
| GetStringAsync                              | .NET 8.0 | .NET 8.0 | 100   |   178.5 μs |   1.93 μs |   1.80 μs |  0.97 |    0.01 |    5.8594 |         - |        - |    23.7 KB |        0.66 |
| GetFromJsonAsync                            | .NET 8.0 | .NET 8.0 | 100   |   177.3 μs |   0.82 μs |   0.77 μs |  0.96 |    0.01 |    1.9531 |         - |        - |     9.2 KB |        0.26 |
|                                             |          |          |       |            |           |           |       |         |           |           |          |            |             |
| **GetAsync_ReadAsStringAsync**                  | **.NET 6.0** | **.NET 6.0** | **1000**  |   **943.7 μs** |  **17.10 μs** |  **25.59 μs** |  **1.00** |    **0.00** |   **86.9141** |   **86.9141** |  **86.9141** |  **457.44 KB** |        **1.00** |
| GetAsync_ReadAsStreamAsync                  | .NET 6.0 | .NET 6.0 | 1000  |   953.5 μs |  18.63 μs |  23.56 μs |  1.01 |    0.04 |   78.1250 |   39.0625 |  39.0625 |  306.46 KB |        0.67 |
| GetAsync_ReadFromJsonAsync                  | .NET 6.0 | .NET 6.0 | 1000  |   942.4 μs |  13.52 μs |  11.99 μs |  0.99 |    0.04 |   78.1250 |   39.0625 |  39.0625 |  306.84 KB |        0.67 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 1000  |   938.0 μs |  13.43 μs |  16.99 μs |  0.99 |    0.04 |  126.9531 |   82.0313 |  82.0313 |  457.78 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 1000  |   823.9 μs |  16.45 μs |  21.39 μs |  0.87 |    0.03 |   13.6719 |         - |        - |   58.92 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 1000  |   807.1 μs |  12.75 μs |  11.30 μs |  0.85 |    0.03 |   13.6719 |    0.9766 |        - |   59.41 KB |        0.13 |
| GetStreamAsync                              | .NET 6.0 | .NET 6.0 | 1000  |   818.0 μs |  14.60 μs |  15.62 μs |  0.86 |    0.04 |   13.6719 |    0.9766 |        - |   58.84 KB |        0.13 |
| GetStringAsync                              | .NET 6.0 | .NET 6.0 | 1000  |   890.8 μs |   3.97 μs |   3.31 μs |  0.94 |    0.03 |   59.5703 |   45.8984 |  44.9219 |  209.86 KB |        0.46 |
| GetFromJsonAsync                            | .NET 6.0 | .NET 6.0 | 1000  |   957.2 μs |  15.11 μs |  13.40 μs |  1.01 |    0.03 |   78.1250 |   39.0625 |  39.0625 |     307 KB |        0.67 |
| GetAsync_ReadAsStringAsync                  | .NET 7.0 | .NET 7.0 | 1000  |   935.6 μs |  12.55 μs |  14.46 μs |  0.99 |    0.04 |  127.9297 |   84.9609 |  83.0078 |  457.22 KB |        1.00 |
| GetAsync_ReadAsStreamAsync                  | .NET 7.0 | .NET 7.0 | 1000  |   964.6 μs |  12.06 μs |  10.07 μs |  1.01 |    0.04 |   78.1250 |   39.0625 |  39.0625 |  306.09 KB |        0.67 |
| GetAsync_ReadFromJsonAsync                  | .NET 7.0 | .NET 7.0 | 1000  |   985.9 μs |  19.07 μs |  23.42 μs |  1.04 |    0.04 |   78.1250 |   39.0625 |  39.0625 |  306.44 KB |        0.67 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 1000  |   935.0 μs |  11.04 μs |   9.22 μs |  0.98 |    0.04 |  125.9766 |   83.9844 |  82.0313 |  457.28 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 1000  |   761.9 μs |  14.86 μs |  20.34 μs |  0.81 |    0.03 |   13.6719 |    0.9766 |        - |   57.97 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 1000  |   765.7 μs |  14.78 μs |  14.52 μs |  0.81 |    0.03 |   13.6719 |    1.9531 |        - |   58.26 KB |        0.13 |
| GetStreamAsync                              | .NET 7.0 | .NET 7.0 | 1000  |   753.4 μs |  12.68 μs |  11.24 μs |  0.79 |    0.03 |   13.6719 |    1.9531 |        - |   57.92 KB |        0.13 |
| GetStringAsync                              | .NET 7.0 | .NET 7.0 | 1000  |   923.3 μs |  18.13 μs |  24.81 μs |  0.98 |    0.04 |   56.6406 |   42.9688 |  42.9688 |   209.4 KB |        0.46 |
| GetFromJsonAsync                            | .NET 7.0 | .NET 7.0 | 1000  |   964.1 μs |  14.68 μs |  13.01 μs |  1.01 |    0.03 |   78.1250 |   39.0625 |  39.0625 |   306.6 KB |        0.67 |
| GetAsync_ReadAsStringAsync                  | .NET 8.0 | .NET 8.0 | 1000  |   840.3 μs |  13.26 μs |  10.35 μs |  0.88 |    0.03 |  126.9531 |   82.0313 |  82.0313 |     457 KB |        1.00 |
| GetAsync_ReadAsStreamAsync                  | .NET 8.0 | .NET 8.0 | 1000  |   860.0 μs |  11.75 μs |   9.81 μs |  0.90 |    0.03 |   78.1250 |   39.0625 |  39.0625 |  305.83 KB |        0.67 |
| GetAsync_ReadFromJsonAsync                  | .NET 8.0 | .NET 8.0 | 1000  |   884.3 μs |  15.85 μs |  26.92 μs |  0.94 |    0.04 |   78.1250 |   39.0625 |  39.0625 |  306.13 KB |        0.67 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 1000  |   850.7 μs |  14.33 μs |  17.06 μs |  0.90 |    0.03 |  126.9531 |   83.9844 |  82.0313 |  457.11 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 1000  |   650.5 μs |   5.66 μs |   5.30 μs |  0.69 |    0.02 |   13.6719 |    1.9531 |        - |    57.9 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 1000  |   661.7 μs |  12.91 μs |  18.51 μs |  0.70 |    0.03 |   13.6719 |    0.9766 |        - |   58.17 KB |        0.13 |
| GetStreamAsync                              | .NET 8.0 | .NET 8.0 | 1000  |   653.2 μs |   9.31 μs |   7.78 μs |  0.69 |    0.03 |   13.6719 |    0.9766 |        - |   57.89 KB |        0.13 |
| GetStringAsync                              | .NET 8.0 | .NET 8.0 | 1000  |   830.6 μs |  14.44 μs |  19.28 μs |  0.88 |    0.04 |   56.6406 |   42.9688 |  42.9688 |  209.21 KB |        0.46 |
| GetFromJsonAsync                            | .NET 8.0 | .NET 8.0 | 1000  |   666.2 μs |  13.25 μs |  22.86 μs |  0.71 |    0.03 |   13.6719 |    0.9766 |        - |   58.67 KB |        0.13 |
|                                             |          |          |       |            |           |           |       |         |           |           |          |            |             |
| **GetAsync_ReadAsStringAsync**                  | **.NET 6.0** | **.NET 6.0** | **10000** | **8,376.3 μs** |  **72.09 μs** |  **63.91 μs** |  **1.00** |    **0.00** | **1140.6250** | **1046.8750** | **984.3750** |  **4924.2 KB** |        **1.00** |
| GetAsync_ReadAsStreamAsync                  | .NET 6.0 | .NET 6.0 | 10000 | 8,396.4 μs |  91.47 μs |  81.08 μs |  1.00 |    0.01 |  593.7500 |  562.5000 | 500.0000 | 2662.97 KB |        0.54 |
| GetAsync_ReadFromJsonAsync                  | .NET 6.0 | .NET 6.0 | 10000 | 8,257.0 μs |  62.96 μs |  52.57 μs |  0.99 |    0.01 |  593.7500 |  562.5000 | 500.0000 | 2664.14 KB |        0.54 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10000 | 8,361.2 μs | 111.52 μs |  93.13 μs |  1.00 |    0.01 | 1140.6250 | 1062.5000 | 984.3750 | 4924.35 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10000 | 6,633.6 μs |  60.15 μs |  56.26 μs |  0.79 |    0.01 |  101.5625 |   62.5000 |  39.0625 |  650.24 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 6.0 | .NET 6.0 | 10000 | 6,578.9 μs |  70.63 μs |  58.98 μs |  0.79 |    0.01 |  101.5625 |   62.5000 |  39.0625 |  650.46 KB |        0.13 |
| GetStreamAsync                              | .NET 6.0 | .NET 6.0 | 10000 | 6,636.0 μs |  59.33 μs |  52.60 μs |  0.79 |    0.01 |  101.5625 |   62.5000 |  39.0625 |  650.11 KB |        0.13 |
| GetStringAsync                              | .NET 6.0 | .NET 6.0 | 10000 | 8,272.5 μs |  61.21 μs |  51.11 μs |  0.99 |    0.01 |  328.1250 |  312.5000 | 250.0000 | 2917.49 KB |        0.59 |
| GetFromJsonAsync                            | .NET 6.0 | .NET 6.0 | 10000 | 8,239.3 μs |  74.91 μs |  62.56 μs |  0.98 |    0.01 |  593.7500 |  562.5000 | 500.0000 |  2664.9 KB |        0.54 |
| GetAsync_ReadAsStringAsync                  | .NET 7.0 | .NET 7.0 | 10000 | 8,387.0 μs | 119.67 μs | 106.09 μs |  1.00 |    0.02 | 1109.3750 | 1046.8750 | 984.3750 | 4923.89 KB |        1.00 |
| GetAsync_ReadAsStreamAsync                  | .NET 7.0 | .NET 7.0 | 10000 | 8,222.8 μs |  97.29 μs |  75.95 μs |  0.98 |    0.01 |  593.7500 |  593.7500 | 500.0000 | 2662.62 KB |        0.54 |
| GetAsync_ReadFromJsonAsync                  | .NET 7.0 | .NET 7.0 | 10000 | 8,392.2 μs | 150.80 μs | 161.36 μs |  1.00 |    0.02 |  609.3750 |  609.3750 | 500.0000 | 2662.97 KB |        0.54 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10000 | 8,473.6 μs | 168.70 μs | 149.55 μs |  1.01 |    0.02 | 1109.3750 | 1078.1250 | 984.3750 | 4923.27 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10000 | 6,519.5 μs | 104.78 μs | 166.19 μs |  0.79 |    0.02 |  101.5625 |   62.5000 |  39.0625 |  649.55 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 7.0 | .NET 7.0 | 10000 | 6,537.9 μs | 122.67 μs | 108.75 μs |  0.78 |    0.02 |  101.5625 |   62.5000 |  39.0625 |  649.93 KB |        0.13 |
| GetStreamAsync                              | .NET 7.0 | .NET 7.0 | 10000 | 6,380.8 μs |  86.77 μs |  72.46 μs |  0.76 |    0.01 |  101.5625 |   62.5000 |  39.0625 |  649.66 KB |        0.13 |
| GetStringAsync                              | .NET 7.0 | .NET 7.0 | 10000 | 8,329.7 μs | 153.69 μs | 136.24 μs |  0.99 |    0.02 |  296.8750 |  281.2500 | 218.7500 | 2917.02 KB |        0.59 |
| GetFromJsonAsync                            | .NET 7.0 | .NET 7.0 | 10000 | 8,280.8 μs |  65.14 μs |  54.39 μs |  0.99 |    0.01 |  609.3750 |  609.3750 | 500.0000 | 2663.26 KB |        0.54 |
| GetAsync_ReadAsStringAsync                  | .NET 8.0 | .NET 8.0 | 10000 | 7,602.1 μs | 101.94 μs |  90.36 μs |  0.91 |    0.01 | 1109.3750 | 1078.1250 | 984.3750 | 4922.75 KB |        1.00 |
| GetAsync_ReadAsStreamAsync                  | .NET 8.0 | .NET 8.0 | 10000 | 7,361.8 μs | 102.72 μs |  91.06 μs |  0.88 |    0.01 |  601.5625 |  601.5625 | 500.0000 | 2662.08 KB |        0.54 |
| GetAsync_ReadFromJsonAsync                  | .NET 8.0 | .NET 8.0 | 10000 | 7,437.7 μs | 148.70 μs | 146.05 μs |  0.89 |    0.02 |  593.7500 |  593.7500 | 500.0000 | 2662.61 KB |        0.54 |
| GetAsync_ReadAsStringAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10000 | 7,751.1 μs | 152.78 μs | 142.91 μs |  0.93 |    0.02 | 1093.7500 | 1093.7500 | 984.3750 | 4923.02 KB |        1.00 |
| GetAsync_ReadAsStreamAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10000 | 5,500.8 μs | 106.87 μs | 131.24 μs |  0.66 |    0.02 |  101.5625 |   62.5000 |  39.0625 |  649.35 KB |        0.13 |
| GetAsync_ReadFromJsonAsync_CompletionOption | .NET 8.0 | .NET 8.0 | 10000 | 5,563.7 μs | 105.66 μs | 137.39 μs |  0.67 |    0.02 |  101.5625 |   62.5000 |  39.0625 |  649.62 KB |        0.13 |
| GetStreamAsync                              | .NET 8.0 | .NET 8.0 | 10000 | 5,655.3 μs | 106.13 μs | 108.98 μs |  0.68 |    0.01 |  101.5625 |   62.5000 |  39.0625 |   649.3 KB |        0.13 |
| GetStringAsync                              | .NET 8.0 | .NET 8.0 | 10000 | 7,206.3 μs |  63.39 μs |  56.20 μs |  0.86 |    0.01 |  335.9375 |  328.1250 | 250.0000 | 2915.91 KB |        0.59 |
| GetFromJsonAsync                            | .NET 8.0 | .NET 8.0 | 10000 | 5,578.0 μs |  93.96 μs |  83.29 μs |  0.67 |    0.01 |  101.5625 |   62.5000 |  39.0625 |  650.23 KB |        0.13 |
