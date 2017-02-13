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

        public void TimeSplitter()
        {
            SetMinutes((_userInput % 1000) % 100);
            SetHours((_userInput - _minutes) / 100);
        }

        public void ConvertToDegrees()
        {
            SetMinuteDeg(GetMinutes()*6);
            SetHourDeg(GetHours()*30);
        }

        public int ExecuteAngle()
        {
            int degreeDiff = Math.Abs(_minuteDeg - _hourDeg);
            if (degreeDiff > 180)
            {
                return 360 - degreeDiff;
            }
            return degreeDiff;
        }


        public int ReturnInput()
        {
            return _userInput;
        }

        public int GetMinutes()
        {
            return _minutes;
        }
        public void SetMinutes(int newMinutes)
        {
            _minutes = newMinutes;
        }
        public int GetHours()
        {
            return _hours;
        }
        public void SetHours(int newHours)
        {
            _hours = newHours;
        }
        public int GetMinuteDeg()
        {
            return _minuteDeg;
        }
        public void SetMinuteDeg(int newMinuteDeg)
        {
            _minuteDeg = newMinuteDeg;
        }

        public int GetHourDeg()
        {
            return _hourDeg;
        }
        public void SetHourDeg(int newHourDeg)
        {
            _hourDeg = newHourDeg;
        }




    }
}
