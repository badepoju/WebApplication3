using System;
using WebApplication3.Controllers;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();        [Fact]        public void GetResultValues()        {            var returnValue = controller.Get(1);            Assert.Equal("300", returnValue.Value);        }

        [Fact]
        public void Test1()
        {

        }
    }
}
