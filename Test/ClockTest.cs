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
        [Fact]
        public void ConvertHoursToDegrees_GetHourDegrees_HourDegrees()
        {
            //Arrange
            int userInputNumber = 0610;
            int hoursDeg = 180;
            Clock ClockTest = new Clock(userInputNumber);
            ClockTest.TimeSplitter();

            //Act
            ClockTest.ConvertToDegrees();

            //Assert
            Assert.Equal(hoursDeg, ClockTest.GetHourDeg());
        }
        [Fact]
        public void ConvertMinutesToDegrees_GetMinutesDegrees_MinuteDegrees()
        {
            //Arrange
            int userInputNumber = 0610;
            int minutesDeg = 60;
            Clock ClockTest = new Clock(userInputNumber);
            ClockTest.TimeSplitter();

            //Act
            ClockTest.ConvertToDegrees();

            //Assert
            Assert.Equal(minutesDeg, ClockTest.GetMinuteDeg());
        }
        [Fact]
        public void ExecuteAngle_DiffOfXAndYDeg_AngleDiff()
        {
            //Arrange
            int userInputNumber = 1245;
            int trueDeg = 90;
            Clock ClockTest = new Clock(userInputNumber);
            ClockTest.TimeSplitter();
            ClockTest.ConvertToDegrees();

            //Act
            int testTest = ClockTest.ExecuteAngle();

            //Assert
            Assert.Equal(trueDeg, testTest);
        }
    }
}
