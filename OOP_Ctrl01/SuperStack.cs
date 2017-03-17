using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ctrl01 {
    class SuperStack<T> : Stack<T> {

        public static bool operator ==(SuperStack<T> st1, SuperStack<T> st2) {
            try {
                if (st1.Count == 0 ||
                    st2.Count == 0) {
                    throw new InsufficientExecutionStackException( );
                }
                return st1.Count == st2.Count;
            } catch (NullReferenceException) {
                return false;
            }
        }

        public static bool operator !=(SuperStack<T> st1, SuperStack<T> st2) {
            return !(st1 == st2);
        }

    }
}
