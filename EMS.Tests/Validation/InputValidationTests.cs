using EMS.Validation;

namespace EMS.Tests.Validation
{
    public class InputValidationTests
    {
        private readonly InputValidation _inputValidation = new();

        [Theory]
        [InlineData(5, 10, true)]   
        [InlineData(1, 10, true)]   
        [InlineData(10, 10, true)]  
        [InlineData(0, 10, false)]  
        [InlineData(11, 10, false)] 
        [InlineData(-1, 10, false)] 
        public void CheckIntRange_ShouldReturnCorrectValidation(int checkInt, int maxRange, bool expected)
        {
            
            bool result = _inputValidation.CheckIntRange(checkInt, maxRange);

            
            Assert.Equal(expected, result);
        }
    }
}