using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class Student : People, IGood, IBad {

        public void minus( ) {
            Console.WriteLine("-");
        }

        public void plus( ) {
            Console.WriteLine("+");
        }
    }
}
