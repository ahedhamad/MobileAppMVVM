using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssignmentMobile33.Model;


namespace AssignmentMobile33.ModelView1
{
    public class MViewUser : ViewParant
    {
        private List<User> Users = null;
        public delegate void NewAddDelegate(int id, string Name, int Age);
        public delegate void DeleteDelegate(int index);
        public delegate void UpdateDelegate();
        public delegate void ExpectionThrown(string Ex);
        public NewAddDelegate OnAdd;
        public DeleteDelegate Ondelete;
        public UpdateDelegate OnUpdate;
        public ExpectionThrown OnExpection;
        public MViewUser()
        {
            Users = new List<User>();
        }

        public override void Add()
        {
            Users.Add(new User(3, "Ali", 30));
            if (OnAdd != null)
            {
                OnAdd(3, "Ali", 30);
            }
            Users.Add(new User(5, "Mohammad", 18));
            if (OnAdd != null)
            {
                OnAdd(5, "Mohammad", 18);
            }

        }
        public  void RemoveAt(int index)
        {
            if (Users.Count == 0)
            {

                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }

            }
            else if (index >= Users.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {Users.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index[{ index}] out of bound expection.List size is { Users.Count }");
                    }
                }
            }
            Users.RemoveAt(index);
            if (Ondelete != null)
            {
                Ondelete(index);
            }

        }
        public override void UpdateList(int id )
        {
            var result = from User in Users where User.Id == id select User;

            result.First().Name = "Aya";
            if (OnUpdate != null)
            {
                OnUpdate();
            }

        }
        public void DuplicateID(int id) 
        {
            if (Users.Exists(x => x.Id == id))
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
            if (Users.Count == 0)
            {
                throw new ListEmpty("the List is empty");
                {
                    if (OnExpection != null)
                    {
                        OnExpection("the List is empty");
                    }
                }

            }
            else if (index >= Users.Count)
            {
                throw new OutOfListSizeExpection($" index [{index}] out of bound expection.List size is {Users.Count}");
                {
                    if (OnExpection != null)
                    {
                        OnExpection($" index [{index}] out of bound expection.List size is {Users.Count}");
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


