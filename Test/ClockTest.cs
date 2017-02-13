using Xunit;

namespace ClockApp
{
    public class ClockTest
    {
        [Fact]
        public void Clock_InputOutputNumber_InputNumber()
        {
            //Arrange
            int userInputNumber = 3;
            Clock ClockTest = new Clock(userInputNumber);

            //Act
            int clockDisplay = ClockTest.ReturnInput();

            //Assert
            Assert.Equal(userInputNumber, clockDisplay);
        }
        [Fact]
        public void TimeSplitter_GetMinutes_Minutes()
        {
            //Arrange
            int userInputNumber = 2134;
            int minutes = 34;
            Clock ClockTest = new Clock(userInputNumber);

            //Act
            ClockTest.TimeSplitter();

            //Assert
            Assert.Equal(minutes, ClockTest.GetMinutes());
        }
        [Fact]
        public void TimeSplitter_GetHours_Hours()
        {
            //Arrange
            int userInputNumber = 2134;
            int hours = 21;
            Clock ClockTest = new Clock(userInputNumber);

            //Act
            ClockTest.TimeSplitter();

            //Assert
            Assert.Equal(hours, ClockTest.GetHours());
        }
    }
}
