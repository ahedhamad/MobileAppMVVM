using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssignmentMobile33.Model;

namespace AssignmentMobile33.ModelView1
{
    
    public class MViewStaffUser : ViewParant
    {
        public List<StaffUser> staffs = null;
        public delegate void NewAddDelegate(int id, string Name, int Age);
        public delegate void DeleteDelegate(int index);
        public delegate void UpdateDelegate();
        public delegate void ExpectionThrown(string Ex);
        public NewAddDelegate OnAdd;
        public DeleteDelegate Ondelete;
        public UpdateDelegate OnUpdate;
        public ExpectionThrown OnExpection;

        public MViewStaffUser()
        {
            staffs =  new List<StaffUser>();
            }
        public override void Add()
        {
            staffs.Add(new StaffUser(1, "Ahmad", 20));
            if (OnAdd != null)
            {
                OnAdd(1, "Ahmad", 20);
            }
            staffs.Add(new StaffUser(3, "Omar", 27));
            if (OnAdd != null)
            {
                OnAdd(3, "Omar", 27);
            }

        }
        public void RemoveAt(int index)
        {
            if (staffs.Count == 0)
            {

                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }

            }
            else if (index >= staffs.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {staffs.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index[{ index}] out of bound expection.List size is { staffs.Count }");
                    }
                }
            }
            staffs.RemoveAt(index);
            if (Ondelete != null)
            {
                Ondelete(index);
            }
        }
        public override void UpdateList()
        {
            var result = from StaffUser in staffs where StaffUser.Id == 27 select StaffUser;

            result.First().Name = "Aya";
            if (OnUpdate != null)
            {
                OnUpdate();
            }

        }
        public void DuplicateID(int id) //بدي اغير من staff الى user ضروووورييييي؟؟؟؟؟؟؟؟؟؟؟؟؟؟ظ
        {
            if (staffs.Exists(x => x.Id == id))
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
            if (staffs.Count == 0)
            {
                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }

            }
            else if (index >= staffs.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {staffs.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index [{index}] out of bound expection.List size is {staffs.Count}");
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
