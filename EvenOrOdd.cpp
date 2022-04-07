#include <string>

std::string even_or_odd(int number) 
{
  std::string Discover;
  if(number%2 == 0)
  {
    Discover = "Even";
  }
  else
  {
    Discover = "Odd";
  }
  return Discover;
}