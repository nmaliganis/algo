using System;
using System.Linq;

namespace ArrayReversal
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Reverse an Array without Temp Buffer");

      int[] numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

      Reverse(numbers);

      Console.ReadLine();
    }

    public static void Reverse(int[] arrayToBeReversed)
    {
      if(arrayToBeReversed == null || arrayToBeReversed.Length <= 1)
        return;

      for (int i = 0; i < arrayToBeReversed.Length / 2; i++)
      {
        int temp = arrayToBeReversed[i];

        arrayToBeReversed[i] = arrayToBeReversed[arrayToBeReversed.Length - 1 - i];
        arrayToBeReversed[arrayToBeReversed.Length - 1 - i] = temp;
      }

      arrayToBeReversed.ToList().ForEach(i => Console.WriteLine(i.ToString()));
      //For Bellow for printing
      //Console.WriteLine($"arrayToBeReversed Array: {arrayToBeReversed.ToString()}");
    }
  }
}
