using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public enum ResultCode
    {
        Success,
        InsufficientFunds,
        CancelledCard,
        ReadError,
        UnknownError
    }
}
