using Xunit;

namespace Algorithms.Test
{
    public class ValidParenthesesTest
    {
        ValidParentheses _validParentheses;
        public ValidParenthesesTest()
        {
            _validParentheses = new ValidParentheses();
        }
        [Fact]
        public void IsValid_EmptyString_ReturnFalse() {
            string stringSymbols = string.Empty;
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyLeftParenthesis_ReturnFalse() {
            string stringSymbols = "(((((((((((";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyRightParenthesis_ReturnFalse() {
            string stringSymbols = "))))))))))))";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyOpenBrace_ReturnFalse() {
            string stringSymbols = "{{{{{{{{{{{{";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyCloseBrace_ReturnFalse() {
            string stringSymbols = "}}}}}}}}}}}}";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyOpenBracket_ReturnFalse() {
            string stringSymbols = "[[[[[[[[[[[[";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OnlyClosedBracket_ReturnFalse() {
            string stringSymbols = "]]]]]]]]]]]]";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OtherChar_ReturnFalse() {
            string stringSymbols = "¡?!<>¿";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_ThreeParOfChars_ReturnTrue()
        {
            string stringSymbols = "()[]{}";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.True(result);
        }
        [Fact]
        public void IsValid_ParenthesesAndBracket_ReturnFalse()
        {
            string stringSymbols = "([)]";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_BracketAndBrace_ReturnTrue() {
            string stringSymbols = "{[]}";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.True(result);
        }
        [Fact]
        public void IsValid_OpenParenthesesCloseBracket_ReturnFalse() {
            string stringSymbols = "(]";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_CloseBracket_ReturnFalse() {
            string stringSymbols = "]";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_CloseParenthesesOpenBrace_ReturnFalse() {
            string stringSymbols = "){";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_BracesWithoutClose_ReturnFalse() {
            string stringSymbols = "(){}}{";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_BracketWithoutOpen_ReturnFalse() {
            string stringSymbols = "(])";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_BracketAndCloseParentheses_ReturnFalse() {
            string stringSymbols = "[])";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.False(result);
        }
        [Fact]
        public void IsValid_OpenAndCloseParentheses_ReturnTrue() {
            string stringSymbols = "(((((())))))";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.True(result);
        }
        [Fact]
        public void IsValid_Parentheses_ReturnTrue() {
            string stringSymbols = "((()(())))";
            bool result = _validParentheses.IsValid(stringSymbols);
            Assert.True(result);
        }
    }
}
