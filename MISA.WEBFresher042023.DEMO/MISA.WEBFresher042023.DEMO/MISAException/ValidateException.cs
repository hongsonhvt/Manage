namespace MISA.WEBFresher042023.DEMO.MISAException
{
    public class ValidateException : Exception
    {
        public List<string> Errors { get; set; }

        public ValidateException() { }
    }
}
