using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace AssignmentMobile33.Model
{
    public class StaffUser     //learn about enum 
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public enum role {Role1, Role2 , Role3 }

        public StaffUser(int Id, string Name, int Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
            }

        public StaffUser()
        {
        }

        public override string ToString()
            {

            var values = Enum.GetValues(typeof(role));
            return $"Id:{this.Id} - Name :{this.Name} - Age :{this.Age} - role:{values}";

            }
        public override bool Equals(object obj)
        {
            var other = obj as StaffUser;
            if (other != null && GetType() == other.GetType()&& Id == other.Id 
                && Name == other.Name && Age == other.Age) //&& role.Equals(other.role)
                return true;
            else
            return false;
        }

    }
}
