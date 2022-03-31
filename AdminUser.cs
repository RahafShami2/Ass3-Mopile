using System;
using System.Collections.Generic;
using System.Text;
namespace Ass3Mo
{
    //the same as the user ..
    namespace Model
    {
        public class AdminUser : User
        {
            List<StaffUser> staff = new List<StaffUser>();
            static void Main(string[] args)
            {
                AdminUser admin = new AdminUser() { Id = 10, Name = "Noor", Age = 12, staff = { } };
                Console.WriteLine(admin.ToString());
                Console.ReadLine();
            }
        }
    }
}


