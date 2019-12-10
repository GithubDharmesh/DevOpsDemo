using System;
using Xunit;
using WebAPIdemo.Controllers;

namespace WebAPIDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        ValuesController _controller=new ValuesController();
        [Fact]
        public void GetReturnValues()
        {
        //Given
        var returnvalue=_controller.Get(1);
        Assert.Equal("value1",returnvalue.Value);
      
        }

    }
}
