using System;
using System.Collections.Generic;

namespace ClockApp
{
    public class Clock
    {
        public Clock(int aMilitaryTime)
        {
            _userInput = aMilitaryTime;
        }

        private int _userInput;
        private int _minutes;
        private int _hours;
        private int _minuteDeg;
        private int _hourDeg;

        public int GetMinutes()
        {
            return _minutes;
        }
        public int GetHours()
        {
            return _hours;
        }
        public int GetMinuteDeg()
        {
            return _minuteDeg;
        }
        public int GetHourDeg()
        {
            return _hourDeg;
        }

        public int ReturnInput()
        {
            return _userInput;
        }

        public void TimeSplitter()
        {
            _minutes = ((_userInput % 1000) % 100);
            _hours = (_userInput - _minutes) / 100;
        }
    }
}
