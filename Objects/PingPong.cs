using System;
using System.Collections;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
    public static string CountTo(int userNum)
    {
      string numCount = "";
      for (int index = 1; index <= userNum; index ++)
      {
        if(index % 15 == 0)
        {
          numCount += "ping-pong ";
        }
        else if (index % 5 == 0)
        {
          numCount += "pong ";
        }
        else if(index % 3 == 0)
        {
          numCount += "ping ";
        }
        else
        {
          numCount += index + " ";
        }
      }
      return numCount;
    }
  }
}
