using System;
using System.Collections.Generic;
using System.Text;
using Simplepro1;
using Xunit;

namespace Simplepro1.Tests
{
    public class Tests3
    {
        [Fact]
        public void Add_numvalues()
        {
            //arrange
            int expected = 10;

            //act
            int actual = 5;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
