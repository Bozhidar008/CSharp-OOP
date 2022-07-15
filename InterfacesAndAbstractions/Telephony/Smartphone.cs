using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : IPhone, IWeb
    {
        public void MakeACall(int number)
        {
            Console.WriteLine($"Calling...{number}");
        }

        public void SerchWeb(string site)
        {
            Console.WriteLine($"Browsing: {site}");
        }
    }
}
