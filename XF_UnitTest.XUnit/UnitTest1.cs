using System;
using XF_UnitTest.ViewModels;
using Xunit;

namespace XF_UnitTest.XUnit
{
    public class UnitTest1
    {
        LoginViewModel login;
        public UnitTest1()
        {
            login = new LoginViewModel();
        }

        [Fact]
        public void Test1()
        {
            var res= login.Suma(a:12,b:13);

            Assert.Equal("24", res.ToString());
        }
    }
}
