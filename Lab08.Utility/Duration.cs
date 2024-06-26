using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.Utility
{
    public class Duration
    {
        #region Properties
        public uint Hours { get; set; }
        public uint Minutes { get; set; }
        public uint Seconds { get; set; }
        #endregion

        #region Ctors
        public Duration(uint hours, uint minutes, uint seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            CalcDuration();
        }
        public Duration(uint minutes, uint seconds) : this(0, minutes, seconds) { }
        public Duration(uint seconds) : this(0, 0, seconds) { }
        #endregion

        #region Operators Overloading
        public static Duration operator +(Duration l, Duration r) => new Duration(l.Hours + r.Hours, l.Minutes + r.Minutes, l.Seconds + r.Seconds);
        public static Duration operator +(Duration d, uint seconds) => new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        public static Duration operator +(uint seconds, Duration d) => d + seconds;
        public static Duration operator ++(Duration d) => new Duration(d.TotalSeconds() + 60);
        public static Duration operator --(Duration d) => new Duration(d.TotalSeconds() - 60);
        public static bool operator <(Duration l, Duration r) => l.TotalSeconds() < r.TotalSeconds();
        public static bool operator >(Duration l, Duration r) => l.TotalSeconds() > r.TotalSeconds();
        public static bool operator <=(Duration l, Duration r) => l.TotalSeconds() <= r.TotalSeconds();
        public static bool operator >=(Duration l, Duration r) => l.TotalSeconds() >= r.TotalSeconds();
        public static bool operator ==(Duration l, Duration r) => l.TotalSeconds() == r.TotalSeconds();
        public static bool operator !=(Duration l, Duration r) => !(l == r); 
        #endregion

        #region Helper Methods

        private void CalcDuration()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
            if (Hours == 0 && Minutes == 0)
            {
                Hours = Seconds / 3600;
                Seconds %= 3600;
                Minutes = Seconds / 60;
                Seconds = Seconds % 60;
            }
        }

        private uint TotalSeconds()
        {
            return  Hours * 3600 + Minutes * 60 + Seconds;
        } 
        #endregion

        #region Override ToString & Equals
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            Duration d = obj as Duration;
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        } 
        #endregion
    }
}
