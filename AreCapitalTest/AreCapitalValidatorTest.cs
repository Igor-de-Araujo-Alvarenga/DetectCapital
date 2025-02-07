using AreCapital;

namespace AreCapitalTest
{
    public class AreCapitalValidatorTest
    {
        [Theory]
        [InlineData("USA")]
        [InlineData("BRA")]
        [InlineData("JAP")]
        public void AllCharsUpper(string word)
        {
            //Arrange
            //Act
            var areCaptial = AreCapitalValidator.DetectCapitalUse(word);
            //Assert
            Assert.True(areCaptial);
        }

        [Theory]
        [InlineData("Google")]
        [InlineData("Microsoft")]
        [InlineData("Apple")]
        public void FirstCharUpper(string word)
        {
            //Arrange
            //Act
            var areCaptial = AreCapitalValidator.DetectCapitalUse(word);
            //Assert
            Assert.True(areCaptial);
        }

        [Theory]
        [InlineData("goGgle")]
        [InlineData("MicRosoft")]
        [InlineData("AppLE")]
        public void InvalidWord(string word)
        {
            //Arrange
            //Act
            var areCaptial = AreCapitalValidator.DetectCapitalUse(word);
            //Assert
            Assert.False(areCaptial);
        }


        [Theory]
        [InlineData("usa")]
        [InlineData("jap")]
        [InlineData("brazil")]
        [InlineData("g")]
        public void OnlyLowerChars(string word)
        {
            //Arrange
            //Act
            var areCaptial = AreCapitalValidator.DetectCapitalUse(word);
            //Assert
            Assert.True(areCaptial);
        }
    }
}