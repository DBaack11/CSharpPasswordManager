using System;
using Xunit;
using EnzoicClient;

namespace PasswordManagerTest
{
    public class UnitTest1
    {
        Enzoic enzoic = new Enzoic("a49513c41c294db080e156a57676e899", "dXtJVmK=k+W^HzQHuPdyzafUYd+n!HM@");
        
        [Fact]
        public void TestCompromisedPassword()
        {
            string password = "Hello";
            Assert.True(enzoic.CheckPassword(password));
        }

        [Fact]
        public void TestNotCompromisedPassword()
        {
            string password = "Hello11$$!!";
            Assert.False(enzoic.CheckPassword(password));
        }
    }
}
