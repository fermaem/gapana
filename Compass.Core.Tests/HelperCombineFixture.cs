﻿using Xunit;

namespace Compass.Core.Tests
{
    public class HelperCombineFixture
    {
        [Fact]
        public void CanCombineTwoStrings()
        {
            Assert.Equal("ab", Helper.Combine("a", "b"));
        }
    }
}
