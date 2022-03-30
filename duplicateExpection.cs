using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMobile33
{
   public class AddNewUserWithDuplicateID :Exception
    {
        public AddNewUserWithDuplicateID(string message) : base(message)
        {

        }
    }
}
