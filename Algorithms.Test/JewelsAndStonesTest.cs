using Xunit;

namespace Algorithms.Test
{
    public class JewelsAndStonesTest
    {
        JewelsAndStones _jewelsAndStones;
        public JewelsAndStonesTest()
        {
            _jewelsAndStones = new JewelsAndStones();
        }

        [Fact]
        public void NumJewelsInStones_LetterA_ReturnThree() {
            string charsToSearch = "aA", charsString = "aAAbbbb";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(3, result);
        }
        [Fact]
        public void NumJewelsInStones_Letterz_ReturnZero()
        {
            string charsToSearch = "z", charsString = "ZZ";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_Numbers_ReturnZero()
        {
            string charsToSearch = "846258", charsString = "hjUHADloK";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_OtherChars_ReturnZero()
        {
            string charsToSearch = "()&&=__", charsString = "DFQQEscvb";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_SpecialChars_ReturnSeven()
        {
            string charsToSearch = "CkÑLl", charsString = "NnCcÑÑÑñLLLAAAA";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(7, result);
        }
        [Fact]
        public void NumJewelsInStones_Uppercase_ReturnThirtyNine()
        {
            string charsToSearch = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", charsString = "aaBBBdddCCCcCCCzzzZKKKKllllMMMnnnnTTTYYYYHJWQSCXASDPOLRY";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(39, result);
        }
        [Fact]
        public void NumJewelsInStones_Lowercase_ReturnThirtyOne()
        {
            string charsToSearch = "abcdefghijklmnopqrstuvwxyz", charsString = "aaBBBdddCCCcCCCzzzZKKKKllllMMMnnnnTTTYYYYHJWQSCXASDPOLRYaabncokpsweñasd";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(31, result);
        }
        [Fact]
        public void NumJewelsInStones_JewelsEmpty_ReturnZero()
        {
            string charsToSearch = "", charsString = "aaBBBdddCCCcCCCzzzZKKKKllllMMMnnnnTTTYYYYHJWQSCXASDPOLRYaabncokpsweñasd";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_JewelsNull_ReturnZero()
        {
            string charsToSearch = null, charsString = "aaBBBdddCCCcCCCzzzZKKKKllllMMMnnnnTTTYYYYHJWQSCXASDPOLRYaabncokpsweñasd";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_StonesEmpty_ReturnZero()
        {
            string charsToSearch = "aBcD", charsString = "";
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void NumJewelsInStones_StonesNull_ReturnZero()
        {
            string charsToSearch = "KLlPwt", charsString = null;
            int result = _jewelsAndStones.NumJewelsInStones(charsToSearch, charsString);
            Assert.Equal(0, result);
        }
    }
}
