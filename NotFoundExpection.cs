using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMobile33
{
    class UpdateDeleteUserThatNotFound : Exception
    {
        public UpdateDeleteUserThatNotFound(string message) : base(message)
        {

        }
    }
}
