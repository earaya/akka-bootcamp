using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail.Messages
{
    internal class InputError
    {
        internal string Reason { get; private set; }

        internal InputError(string reason)
        {
            Reason = reason;
        }
    }

    internal class NullInputError : InputError
    {
        internal NullInputError(string reason) : base(reason) { }
    }

    internal class ValidationError : InputError
    {
        internal ValidationError(string reason) : base(reason) { }
    }
}
