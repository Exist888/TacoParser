using System;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acworth...", -84.677017)]
        [InlineData("34.035985, -84.683302, Taco Bell Acworth...", -84.683302)]
        [InlineData("34.087508, -84.575512, Taco Bell Acworth...", -84.575512)]
        [InlineData("33.59453, -86.694742, Taco Bell Birmingham...", -86.694742)]
        [InlineData("34.8831, -84.293899, Taco Bell Blue Ridge...", -84.293899)]
        //[InlineData(null, 0)]
        
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoLongitude = new TacoParser();

            //Act
            var actual = tacoLongitude.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }
        
        //TODO: Create a test called ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acworth...", 34.073638)]
        [InlineData("34.035985, -84.683302, Taco Bell Acworth...", 34.035985)]
        [InlineData("34.087508, -84.575512, Taco Bell Acworth...", 34.087508)]
        [InlineData("33.59453, -86.694742, Taco Bell Birmingham...", 33.59453)]
        [InlineData("34.8831, -84.293899, Taco Bell Blue Ridge...", 34.8831)]

        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoLatidue = new TacoParser();
            
            //Act
            var actual = tacoLatidue.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
