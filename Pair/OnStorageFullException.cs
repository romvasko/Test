using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class OnStorageFullException : Exception
    {
        public OnStorageFullException()
        {

        }
        public OnStorageFullException(string message)
        : base(message)
        {

        }
    }

    public class OnDeleteException : Exception
    {
        public OnDeleteException()
        {

        }
        public OnDeleteException(string message)
         : base(message)
        {

        }
    }
    public class OnUpdateException : Exception
    {
        public OnUpdateException()
        {

        }
        public OnUpdateException(string message)
        : base(message)
        {

        }
    }
}
