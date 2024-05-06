using System;
using System.Runtime.InteropServices;

namespace SingleNumberII;

class Teste
{
    static void Main(string[] args)
    {

        SolutionCountSeniors solution = new SolutionCountSeniors();

        string[] strings = ["1313579440F2036","2921522980M5644"];  
        int result = solution.CountSeniors(strings);

        Console.WriteLine(result);
    }
}