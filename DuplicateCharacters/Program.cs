using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace DuplicateCharacters
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Duplicate Characters");

      string inputString = "Nikolaos Maliganis";
      CheckForDuplication(inputString);
    }

    public static void CheckForDuplication(string inputChecker)
    {
      char[] inputString = inputChecker.ToCharArray();

      IDictionary<char, int> charMap = new Dictionary<char, int>();

      foreach (var c in inputString)
      {
        if (charMap.ContainsKey(c))
        {
          charMap[c] += 1;
        }

        else
        {
          charMap.Add(new KeyValuePair<char, int>(c, 1));
        }
      }

      foreach (var cm in charMap)
      {
        if (cm.Value > 1)
        {
          Console.WriteLine($"Key:{cm.Key} Repeat Times:{cm.Value}");
        }
      }
    }
  }
}
