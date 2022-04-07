using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      string Discover;
      if(number%2 ==0)
      {
        Discover = "Even";
      }
      else
      {
        Discover = "Odd";
      }
      return Discover;
    }
  }
}