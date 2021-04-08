using System;
using Xunit;

namespace PalindromeTDD.tests
{
    public class TestIfPalindromeIsTrue
    {
        [Fact]
        public void This_will_pass_if_stars_is_false()
        {
            //Assert
            var testString = "Stars";
            var expectedResult = false;

            var tester = new PalindromeTester();
            var testResult = tester.Tester(testString);

            Assert.Equal(expectedResult, testResult);
        }
    }
}
