using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IPhone
    {
        public void MakeACall(int number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
