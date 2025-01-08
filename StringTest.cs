using Xunit;



namespace CiCdgrupp
{

    public class StringTest
    {
        [Fact]
        public void TestToUpper()
        {
            //given
            StringsManipulation stringM = new();

            string originString = "Hello World";
            string expectedResult = "HELLO WORLD";

            //when


            string result = stringM.ToUpper(originString);


            //Then
            Assert.Equal(expectedResult, result);

        }
    }
}