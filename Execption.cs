using System;
using System.Collections.Generic;
using System.Text;

namespace Ass3Mo
{
    public class InvalidExecption : Exception
    {
        public InvalidExecption(string message) : base(message)
        {

        }
    }
    public class DuplicateExecption : Exception
    {
        public DuplicateExecption(string message) : base(message)
        {

        }
    }

    public class NotFoundExecption : Exception
    {
        public NotFoundExecption(string message) : base(message)
        {
            
        }
    }
}