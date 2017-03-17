using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class Program {

        static Random Rand = new Random( );

        static void Main(string[ ] args) {
            Console.WriteLine(ushort.MaxValue);
            string str = Console.ReadLine( );
            Console.WriteLine(str.Contains("123") ? "Contains" : "Not contains");
            double[ ][ ] arr = new double[12][ ];
            for (uint i = 0; i < arr.Length; i++) {
                arr[i] = new double[12];
                for (uint j = 0; j < arr[i].Length; j++) {
                    arr[i][j] = Rand.Next(0, 9);
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine( );
            }

            SuperStack<int> st1 = new SuperStack<int>( );
            SuperStack<int> st2 = new SuperStack<int>( );
            for (uint i = 0; i < 10; i++) {
                st1.Push(Rand.Next(0, 9));
            }
            for (uint i = 0; i < 10; i++) {
                st2.Push(Rand.Next(0, 9));
            }
            try {
                Console.WriteLine(st1 == st2 ? "One sizes" : "Diff sizes");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            string[ ] str1 = {
                "qwerty",
                "asdfg",
                "qwertyui",
                "zxcv",
            };

            Console.WriteLine(
                (
                    from elem in str1
                    where elem.Length > 5
                    select elem
                ).Count( )
            );


            User me = new User("Nick");
            Phone myPhone = new Phone(me);
            myPhone.Ring( );

        }

    }
}
