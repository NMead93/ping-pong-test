using Xunit;
using System.Collections;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void CountTo_CountsToUserNumber_ListFromOnetoUserNumber()
    {
      string testList = "1 2 ping 4 ";
      Assert.Equal(testList, PingPong.CountTo(4));
    }

    [Fact]
    public void CountTo_ReplacesUserNumberWithPongWhenDivisibleByFive()
    {
      string testList = "1 2 ping 4 pong ";
      Assert.Equal(testList, PingPong.CountTo(5));
    }

    [Fact]
    public void CountTo_ReplacesUserNumberWithPingPongWhenDivisibleByFifteen()
    {
      string testList = "1 2 ping 4 pong ping 7 8 ping pong 11 ping 13 14 ping-pong ";
      Assert.Equal(testList, PingPong.CountTo(15));
    }
  }
}
