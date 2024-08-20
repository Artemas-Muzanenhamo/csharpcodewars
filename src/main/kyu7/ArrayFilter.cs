using System.Linq;

public class ArrayFilter
{
  public static int[] GetEvenNumbers(int[] numbers)
  {
    return numbers.Where(number => number % 2 == 0).ToArray();
  }
}