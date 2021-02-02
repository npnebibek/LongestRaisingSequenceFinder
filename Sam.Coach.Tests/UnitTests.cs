using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {

        [Theory]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, -3 }, new[] { 3, 5, 8 })]
        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            int[] actual = null;
            var serviceMock = new Mock<ILongestRisingSequenceFinder>();
            //Setup expected behavior
            serviceMock
               .Setup(m => m.Find(data));//expected service behavior can be verified

            //the system under test
            var sut = new FindLongestSequence(serviceMock.Object);
            actual=await sut.Find(data);
            actual.Should().Equal(expected);
        }
    }
}
