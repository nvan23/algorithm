using System;
using System.Collections.Generic;

namespace tfd1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input:");
      var numberOfCases = int.Parse(Console.ReadLine());
      var cases = new List<String>();
      for (int i = 0; i < numberOfCases; i++)
      {
        cases.Add(Console.ReadLine());
      }
      Console.WriteLine("Output:");
      for (int i = 0; i < numberOfCases; i++)
      {
        Console.WriteLine($"Case #{i + 1}: {solution(cases[i])}");
      }
    }

    private static string solution(string input)
    {
      string result = "";
      string cache = "";
      for (int i = 0;i < input.Length - 1; i++)
      {
        var c = input[i];
        var c1 = input[i + 1];
        cache += c;
        if (c > c1)
        {
          result += cache;
          cache = "";
        }
        else if (c < c1)
        {
          result += cache;
          result += cache;
          cache = "";
        }
      }
      return result += cache + input[^1];
    }
  }
}