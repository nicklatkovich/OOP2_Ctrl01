using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class Phone {

        public delegate void MethodContainer( );

        public event MethodContainer onRing;

        public Phone(User my_user) {
            onRing += my_user.GetPhone;
        }

        public void Ring( ) {
            Console.WriteLine("Ring");
            onRing( );
        }

    }
}
