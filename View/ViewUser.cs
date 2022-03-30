using System;
using System.Collections.Generic;
using System.Text;
using AssignmentMobile33.ModelView1;

namespace AssignmentMobile33.View
{
    public class ViewUser
    {
        static void Main(string[] args)
        {

            MViewStaffUser viewUsers = new MViewStaffUser();
            MViewStaffUser ViewExpection = new MViewStaffUser();
            viewUsers.OnAdd += UpdateAddView;
            viewUsers.Ondelete += UpdateDeleteView;
            viewUsers.OnUpdate += Update_UpdateView;
            ViewExpection.OnExpection += view_Expection;




        }
        private static void UpdateAddView(int id, string Name, int Age)
        {
            Console.WriteLine($"User is added : {id} - {Name} -{Age}");
        }
        private static void UpdateDeleteView(int index)
        {
            Console.WriteLine($"User is deleted by index : {index} ");
        }
        private static void Update_UpdateView()
        {
            Console.WriteLine($"User is Updated");
        }
        private static void view_Expection()
        {
            Console.WriteLine($"is a new expection ");
        }

    }
}

   
