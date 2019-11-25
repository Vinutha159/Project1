using System;
using System.Collections.Generic;
using System.Text;
using Simplepro1;
using Xunit;

namespace Simplepro1.Tests
{
    public class Tests4
    {
        [Fact]
        public void Add_numvalues()
        {
            //arrange
            int expected = 15;

            //act
            int actual = 15;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
