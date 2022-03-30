using System;
using System.Collections.Generic;
using System.Text;
using AssignmentMobile33.ModelView1;
using AssignmentMobile33.Model;


namespace AssignmentMobile33.View
{
   public class ViewAdminUser
    {
        static void Main(string[] args)
        {
            MViewAdminUser ViewAdminUser = new MViewAdminUser();
            MViewAdminUser ViewExpection = new MViewAdminUser();
            ViewAdminUser.OnAdd += UpdateAddView;
            ViewAdminUser.Ondelete += UpdateDeleteView;
            ViewAdminUser.OnUpdate += Update_UpdateView;
            ViewExpection.OnExpection += view_Expection;




        }
        private static void UpdateAddView(int id, string Name, int Age, List<StaffUser> stafU)

        {
            List<StaffUser> stafU1 = new List<StaffUser>();
            Console.WriteLine($"AdminUser is added : {id} - {Name} -{Age}-{stafU}");
        }
        private static void UpdateDeleteView(int index)
        {
            Console.WriteLine($"AdminUser is deleted by index : {index} ");
        }
        private static void Update_UpdateView()
        {
            Console.WriteLine($"AdminUser is Updated");
        }
        private static void view_Expection()
        {
            Console.WriteLine($"is a new expection ");
        }

    }
}

    
