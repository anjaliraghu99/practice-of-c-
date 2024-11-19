using System;
using System.Diagnostics.CodeAnalysis;

//Fibonacci series
// 0 1,1,2,3,5,8

var res = fibonacci(8);
foreach (int item in res)
{
    Console.WriteLine(item);
}


static List<int> fibonacci(int n)
{
    int x = 0;
    int y = 1;
    int sum = 0;
    List<int> list = new List<int>();

    for (int i = 0; i < n; i++)
    {
        sum = x + y;
        x = y;
        y = sum;
        list.Add(sum);

    }
    return list;

}









