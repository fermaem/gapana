using Xunit;
using Xunit.Extensions;

namespace Compass.Core.Tests
{
    public class HelperCombineFixture
    {
        [Theory]
        [InlineData("ab", "a", "b")]
        [InlineData("b", "", "b")]
        public void CanCombineTwoStrings(string expected, string one, string another)
        {
            Assert.Equal(expected, Helper.Combine(one, another));
        }
    }
}
