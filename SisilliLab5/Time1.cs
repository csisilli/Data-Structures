﻿//Name: Caitlin Sisilli
//Lab 5 for .Net
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   namespace SisilliLab5
{
        // Time1 class definition
        public class Time1 : Object
        {
            private int mSeconds;    // 0 -23

            // Time1 constructor initializes instance variables to 
            // zero to set default time to midnight
            public Time1()
            {
                SetTime(0, 0, 0);
            }

            // Set new time value in 24-hour format. Perform validity
            // checks on the data. Set invalid values to zero.
            public void SetTime(
               int hourValue, int minuteValue, int secondValue)
            {
                int hour = (hourValue >= 0 && hourValue < 24) ?
                    hourValue : 0;
                int minute = (minuteValue >= 0 && minuteValue < 60) ?
                    minuteValue : 0;
                int second = (secondValue >= 0 && secondValue < 60) ?
                    secondValue : 0;
                mSeconds = hour * 3600 + minute * 60 + second;

        } // end method SetTime

        // change the hour for minutes
        public int Hour
        {
            get
            {
                return (mSeconds % 3600) / 60;
            }
            set
            {
                //setting the hour to a differnt value to change it to only be seconds
                int hour = (value >= 0 && value < 24) ?
                    value : 0;
                mSeconds = hour + 3600 + this.Minute + 60 + this.Second;
            }
        }
        // change the time for minutes
         public int Minute
        {
            get {
                return (mSeconds%3600)/60; 
            }
            set
            {
                //setting the minute to a differnt value to change it to only be seconds
                int minute = (value >= 0 && value < 60) ?
                    value : 0;
                mSeconds = this.Hour + 3600 + minute + 60 + this.Second;
            }
        }
        // change the time for second
        public int Second
        {
            get
            {
                return (mSeconds % 3600) / 60;
            }
            set
            {
                //setting the second to a differnt value to change it to only be seconds
                int second = (value >= 0 && value < 60) ?
                    value : 0;
                mSeconds = this.Hour + 3600 + this.Minute + 60 + second;
            }
        }
            // convert time to universal-time (24 hour) format string
            public string ToUniversalString()
            {
                return String.Format(
                   "{0:D2}:{1:D2}:{2:D2}", this.Hour, this.Minute, this.Second);
            }

            // convert time to standard-time (12 hour) format string
            public string ToStandardString()
            {
                return String.Format("{0}:{1:D2}:{2:D2} {3}",
                   ((this.Hour == 12 || this.Hour == 0) ? 12 : this.Hour % 12),
                   this.Minute, this.Second, (this.Hour < 12 ? "AM" : "PM"));
            }

        } // end class Time1
    }
