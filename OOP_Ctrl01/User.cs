using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class User {

        string Name;

        public User(string name) {
            Name = name;
        }

        public void GetPhone( ) {
            Console.WriteLine("User " + Name + " took the phone");
        }

    }
}
