namespace Utilities.Exceptions
{
    public class CustomException : Exception
    {
        public int Status { get; set; } = 400;
        public CustomException(string message) : base(message) { }
    }
}
