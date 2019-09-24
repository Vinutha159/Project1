using System;
using System.Collections.Generic;
using System.Text;
using Simplepro1;
using Xunit;

namespace Simplepro1.Tests
{
    public class Tests2
    {
        [Fact]
        public void Add_numvalues()
        {
            //arrange
            int expected = 5;

            //act
            int actual = 3;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
