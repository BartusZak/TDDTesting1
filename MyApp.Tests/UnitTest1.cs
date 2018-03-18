using System;
using Xunit;
using MyApp.CLI;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldSayHelloToMe()
        {
            //arrange
            Greeter greeter = new Greeter();

            //act
            string greeting = greeter.SayHello("John");

            //assert
            Assert.Equal("Hello, John!", greeting);
        }
    }
}
