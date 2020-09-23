using Xunit;

namespace String.Abbreviations.Tests
{
    public class StringsTests
    {
        [Fact]
        public void BrbNormalTest()
        {
            var str = Strings.BRB();
            Assert.Equal("Be right back", str);
        }

        [Fact]
        public void BrbTitleCaseTest()
        {
            var str = Strings.BRB(titleCase: true);
            Assert.Equal("Be Right Back", str);
        }

        [Fact]
        public void ImhoNormalTest()
        {
            var str = Strings.IMHO();
            Assert.Equal("In my humble oppinion", str);
        }

        [Fact]
        public void ImhoTitleCaseTest()
        {
            var str = Strings.IMHO(titleCase: true);
            Assert.Equal("In My Humble Oppinion", str);
        }

        [Fact]
        public void LmaoNormalTest()
        {
            var str = Strings.LMAO();
            Assert.Equal("Laughing my ass off", str);
        }

        [Fact]
        public void LmaoTitleCaseTest()
        {
            var str = Strings.LMAO(titleCase: true);
            Assert.Equal("Laughing My Ass Off", str);
        }

        [Fact]
        public void RotflNormalTest()
        {
            var str = Strings.ROTFL();
            Assert.Equal("Rolling on the floor laughing", str);
        }

        [Fact]
        public void RotflTitleCaseTest()
        {
            var str = Strings.ROTFL(titleCase: true);
            Assert.Equal("Rolling On The Floor Laughing", str);
        }

        [Fact]
        public void AmalNormalTest()
        {
            var str = Strings.AMA();
            Assert.Equal("Ask me anything", str);
        }

        [Fact]
        public void AmaTitleCaseTest()
        {
            var str = Strings.AMA(titleCase: true);
            Assert.Equal("Ask Me Anything", str);
        }
    }
}