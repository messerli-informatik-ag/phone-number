namespace Messerli.Phone
{
    public class PhoneNumber
    {
        private readonly string _rawPhoneNumber;

        public PhoneNumber(string rawPhoneNumber)
            => _rawPhoneNumber = rawPhoneNumber;

        public static PhoneNumber Parse(string rawPhoneNumber)
            => new(ToFullyQualified(rawPhoneNumber.Replace(" ", string.Empty)));

        public override string ToString()
            => _rawPhoneNumber
                .Insert(3, " ")
                .Insert(6, " ")
                .Insert(10, " ")
                .Insert(13, " ")
            ;

        private static string ToFullyQualified(string phoneNumber)
            => phoneNumber.StartsWith("0")
                ? "+41" + phoneNumber.TrimStart('0')
                : phoneNumber;
    }
}
