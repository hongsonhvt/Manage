namespace MISA.WEBFresher042023.DEMO.UNitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(4, 5, 9)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 2)]
        [TestCase(int.MaxValue, 1, (long)int.MaxValue +1)]
        public void  Add_ValidInput_Success(int a, int b, long expectedResult)
        {
            /// Arrange

            /// Act
            var actualResult = new Calculator() .Add(a, b);
            /// Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }


        [TestCase(4, 5, -1)]
        [TestCase(1, 2, -1)]
        [TestCase(1, 1, 0)]
        [TestCase(int.MaxValue, int.MinValue, (long)2 * int.MaxValue + 1)]
        public void Sub_ValidInput_Success(int a, int b, long expectedResult)
        {
            /// Arrange

            /// Act
            var actualResult = new Calculator().Sub(a, b);
            /// Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(4, 5, 20)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        [TestCase(int.MaxValue, int.MinValue, (long)int.MaxValue * int.MinValue)]
        public void Mul_ValidInput_Success(int a, int b, long expectedResult)
        {
            /// Arrange

            /// Act
            var actualResult = new Calculator().Mul(a, b);
            /// Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(4, 5, ((double)4)/5)]
        [TestCase(2, 2, 1)]
        [TestCase(1, 1, 1)]

        public void Div_ValidInput_Success(int a, int b, double expectedResult)
        {
            /// Arrange

            /// Act
            var actualResult = new Calculator().Div(a, b);
            /// Assert
            Assert.That(Math.Abs(actualResult - expectedResult), Is.LessThan(10e-6));
        }

     

        public void Div_InvalidInput_Exception()
        {
            /// Arrange
            var a = 5;
            var b = 0;
            var expectedMessage = "Khong chia duoc cho 0";
            /// Act & Assert
            var  handler = () => new Calculator().Div(a, b);
            /// Assert
            var exception = Assert.Throws<Exception>( () => handler());
            Assert.That(expectedMessage, Is.EqualTo(exception.Message));
        }
    }
    /// Debug dùng Ctrl + R + T
}
