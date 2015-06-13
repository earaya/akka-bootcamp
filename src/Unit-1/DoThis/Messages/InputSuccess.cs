using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail.Messages
{
    internal class InputSuccess
    {
        internal string Reason { get; private set; }

        internal InputSuccess(string reason)
        {
            Reason = reason;
        }
    }
}
