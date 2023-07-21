namespace MISA.WEBFresher042023.DEMO
{
    public class Calculator
    {
        /// <summary>
        ///  Ham cong 2 so nguyen
        /// </summary>
        /// <param name="a"> so hang 1</param>
        /// <param name="b"> so hang 2</param>
        /// <returns> tong  2 so nguyen</returns>
        /// created by: NHSon (9/6/2023)
        public long  Add(int a, int b)
        {
            return (long)a + b;
        }
        /// <summary>
        ///  Ham tru hai so nguyen
        /// </summary>
        /// <param name="a">So hang 1</param>
        /// <param name="b">so hang 2</param>
        /// <returns>Hieu 2 so nguyen</returns>
        /// created by: NHSon (9/6/2023)
        public long Sub(int a, int b )
        {
            return (long)a - b;
        }
        /// <summary>
        ///  Ham nhan 2 so nguyen
        /// </summary>
        /// <param name="a">So hang 1</param>
        /// <param name="b">So hang 2</param>
        /// <returns>Tich 2 so nguyen</returns>
        /// created by: NHSon (9/6/2023)
        /// <exception cref="NotImplementedException"></exception>
        public long Mul(int a, int b)
        {
            return (long)a * b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">So Hang 1</param>
        /// <param name="b">So Hang 2</param>
        /// <returns>Thuong 2 so nguyen</returns>
        /// created by: NHSon (9/6/2023)
        /// <exception cref="NotImplementedException"></exception>
        public double Div(int a, int b)
        {
            if (b==0)
            {
                throw new Exception("khong chia duoc cho 0");
            }
            return (double)a / b;
        }
    }
}
