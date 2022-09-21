using System;
using System.Collections.Generic;

namespace Prime.Models
{
  public class Checker
  {
    public string showPrimes(int userInput)
    {
      List<int> outputList = new List<int> {};
      for (int i = 2; i <= userInput; i++)
      {
        if (i==2 || i==3 || i==5 || i==7 || i==11 || i==13 || i==17 || i==19)
				{
					outputList.Add(i);
				}
				else
				{
					if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0 && i%11!=0 && i%13!=0 && i%17!=0 && i%19!=0)
					{
						outputList.Add(i);
					}
				}
      }
			string outputString = "";
      for (int i=0; i < outputList.Count; i++) {
        outputString += outputList[i];
        if (i != outputList.Count - 1)
        {
          outputString += ", ";
        }
      }
      return outputString;
    }
  }
}