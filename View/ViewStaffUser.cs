using System;
using System.Collections.Generic;
using AssignmentMobile33.ModelView1;
using System.Text;

namespace AssignmentMobile33.View
{
    public class ViewStaffUser
    {
        static void Main(string[] args)
        {
            MViewStaffUser ViewstaffUser = new MViewStaffUser();
            MViewStaffUser ViewExpection = new MViewStaffUser();
        ViewstaffUser.OnAdd += UpdateAddView;
            ViewstaffUser.Ondelete += UpdateDeleteView;
            ViewstaffUser.OnUpdate += Update_UpdateView;
            ViewExpection.OnExpection += viewExpection;

            
          

        }
    private static void UpdateAddView(int id, string Name, int Age)
    {
        Console.WriteLine($"StaffUser is added : {id} - {Name} -{Age}");
    }
    private static void UpdateDeleteView(int index)
    {
        Console.WriteLine($"StaffUser is deleted by index : {index} ");
    }
    private static void Update_UpdateView()
    {
        Console.WriteLine($"StaffUser is Updated");
    }
    private static void viewExpection()
    {
        Console.WriteLine($"is a new expection ");
    }

}
    }

