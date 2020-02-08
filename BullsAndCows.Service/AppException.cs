using System;
using System.Collections.Generic;
using System.Text;

namespace BullsAndCows.Service
{
    public class AppException : Exception
    {
        public AppException() : base() { }
        public AppException(string message) : base(message) { }
       
    }
}
