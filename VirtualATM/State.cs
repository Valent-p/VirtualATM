using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualATM
{
    internal class State
    {
        public static int NONE = 0;
        public static int ENTER_ACCOUNT_NUMBER = 1;
        public static int ENTER_ACCOUNT_PIN = 2;
        public static int CHOOSE_SERVICE = 3;
        public static int WITHDRAW = 4;

    }
}
