using Xunit;

namespace Messerli.Phone.Test
{
    public class PhoneNumberTest
    {
        [Theory]
        [InlineData("+41 78 111 22 33", "078 111 22 33")]
        [InlineData("+41 71 444 00 00", "071 444 00 00")]
        [InlineData("+41 78 123 45 67", "+41 78 123 45 67")]
        [InlineData("+41 78 123 45 67", "0781234567")]
        public void WeCanCreateAPhoneNumberAndGetItFullyQualified(string expected, string inputNumber)
        {
            var phoneNumber = PhoneNumber.Parse(inputNumber);

            Assert.Equal(expected, phoneNumber.ToString());
        }
    }
}
