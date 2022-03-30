using System;
using System.Collections.Generic;
using System.Text;
using AssignmentMobile33.Model;
using System.Linq;

namespace AssignmentMobile33.ModelView1
{
   public class MViewAdminUser : ViewParant
    {
        private List<AdminUser> AdminUsers = null;
        public delegate void NewAddDelegate(int id, string Name, int Age,List<StaffUser> stafU);
        public delegate void DeleteDelegate(int index);
        public delegate void UpdateDelegate();
        public delegate void ExpectionThrown(string Ex);
        public NewAddDelegate OnAdd;
        public DeleteDelegate Ondelete;
        public UpdateDelegate OnUpdate;
        public ExpectionThrown OnExpection;

        public MViewAdminUser()
        {
            AdminUsers = new List<AdminUser>();
        }
        public override void Add()
        {
            List<StaffUser> stafU1 = new List<StaffUser>();
            AdminUsers.Add(new AdminUser(3, "Ali", 30, stafU1));
            if (OnAdd != null)
            {
                OnAdd(3, "Ali", 30, stafU1 );
            }
            List<StaffUser> stafU2 = new List<StaffUser>();
            AdminUsers.Add(new AdminUser(5, "Mohammad", 18, stafU2));
            if (OnAdd != null)
            {
                OnAdd(5, "Mohammad", 18, stafU2);
            }

        }
        public  void RemoveAt(int index)
        {
            if (AdminUsers.Count == 0)
            {

                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }
            }
            else if (index >= AdminUsers.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {AdminUsers.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index[{ index}] out of bound expection.List size is { AdminUsers.Count }");
                    }
                }
            }
            AdminUsers.RemoveAt(index);
            if (Ondelete != null)
            {
                Ondelete(index);
            }


        }
        public override  void UpdateList()
        {
            var result = from AdminUser in AdminUsers where AdminUser.Id == 27 select AdminUser;

            result.First().Name = "Aya";
            if (OnUpdate != null)
            {
                OnUpdate();
            }

        }
        public void DuplicateID(int id)
        {
            if (AdminUsers.Exists(x => x.Id == id))
            {
                throw new AddNewUserWithDuplicateID("User tries to add a new user with a duplicate id");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("User tries to add a new user with a duplicate id");
                    }
                }
            }

        }
        public void NotFoundint(int index)
        {
            //update /delete user
            if (AdminUsers.Count == 0)
            {
                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }

            }
            else if (index >= AdminUsers.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {AdminUsers.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index [{index}] out of bound expection.List size is {AdminUsers.Count}");
                    }
                }
            }
        }
        public void EntersInvaldData(string id, float name, string age)
        {
            Type typeId = id.GetType();
            Type typeName = name.GetType();
            Type typeAge = age.GetType();
            if (typeId.Equals(typeof(int)) != true && typeName.Equals(typeof(string)) != true && typeAge.Equals(typeof(int)) != true)
            {
                throw new EntersInvaldDataException("User enters invald data");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("User enters invald data");
                    }
                }

            }
        }
    }
}
