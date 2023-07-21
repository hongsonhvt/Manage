namespace MISA.WEBFresher042023.DEMO.Core.MISAException
{
    public class ValidateException : Exception
    {
        public List<string> Errors { get; set; }

        public ValidateException() { }
    }
}
