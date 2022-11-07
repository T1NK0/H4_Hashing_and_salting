namespace H4_encryption.Models
{
    public class TestViewModel
    {
        private string plainString;

        public string PlainString
        {
            get { return plainString; }
            set { plainString = value; }
        }

        public TestViewModel()
        {
            PlainString = "Mads";
        }
    }
}
