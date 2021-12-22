namespace DigiturkTest.Common
{
    public class AppSettings
    {
        public Token Token { get; set; }
    }

    public class Token
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int Expires { get; set; }
    }
}