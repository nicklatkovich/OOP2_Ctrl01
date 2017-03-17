using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class Date {

        private ushort _day;

        public ushort Day {
            get { return _day; }
            set {
                if (value < 0 || value > 31) {
                    throw new Exception( );
                } else {
                    _day = Day;
                }
            }
        }
        public ushort Month { get; set; }
        public readonly uint Year;

        Date(ushort day, ushort month, uint year) {
            Day = day;
            Month = month;
            Year = year;
        }

        public override Boolean Equals(Object obj) {
            Date otherDate;
            try {
                otherDate = obj as Date;
                return
                    Day == otherDate.Day &&
                    Month == otherDate.Month &&
                    Year == otherDate.Year;
            } catch {
                return false;
            }
        }

    }
}
