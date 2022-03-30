using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AssignmentMobile33.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {

            return $"Id:{this.Id} - Name :{this.Name} - Age :{this.Age}";

        }
        public override bool Equals(object obj)
        {
            var other = obj as User;
            if (other != null && Id == other.Id && Name == other.Name && Age == other.Age && GetType() == other.GetType())
                return true;
            else
                return false;
        }
    }
}

