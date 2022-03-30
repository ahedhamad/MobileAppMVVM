using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace AssignmentMobile33.Model
{
    public class AdminUser 
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public List<StaffUser> staffUsers ;

            public AdminUser(int Id, string Name, int Age, List<StaffUser> staffUser)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
                staffUsers = new List<StaffUser>();
            }

         public override string ToString()
        {
          StaffUser ResultStaffUsers = new StaffUser();

         foreach (var item in staffUsers)
        {
            ResultStaffUsers = ResultStaffUsers.Add(item);
        }
          return $"Id:{this.Id} - Name :{this.Name} - Age :{this.Age} -staffUser:{ResultStaffUsers}";

         }
        public override bool Equals(object obj)
        {
            var other = obj as AdminUser;
            if (other != null && GetType() == other.GetType()&& Id == other.Id &&
                Name == other.Name && Age == other.Age && staffUsers.Equals(other.staffUsers))
                return true;
            else 
                return false;

        }
      
    }
}
