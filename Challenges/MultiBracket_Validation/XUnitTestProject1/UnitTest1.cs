using System;
using Xunit;
using MultiBracket_Validation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("[]")]
        [InlineData("()")]
        [InlineData("{}[]()")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[([])]]")]
        [InlineData("{}{code}[Fellows]((()))")]
        public void CheckingForReturnTrueValidation(string userinput)
        {
            Assert.True(Program.MultiBracketValidation(userinput));
        }

        [Theory]
        [InlineData("[}")]
        [InlineData("(]]")]
        [InlineData("[[))")]
        [InlineData("([{])}")]
        [InlineData("([)]")]
        [InlineData("{c{o[d[e)f]e}l")]
        [InlineData("[}")]
        [InlineData("(){}[")]
        [InlineData("[({}]")]
        [InlineData("(])")]
        public void CheckingForReturnFalseValidation(string userinput)
        {
            Assert.False(Program.MultiBracketValidation(userinput)); 
        }
    }
}
