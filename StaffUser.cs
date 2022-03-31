using System;
using System.Collections.Generic;
using System.Text;
namespace Ass3Mo
{
    //the same as the user ..
    namespace Model
    {
        public class StaffUser : User
        {
            enum Role
            {
                Role1,
                Role2,
                Role3
            }
            public override string ToString()
            {
                return $"Id: {Id} , Name: {this.Name} , Age: {this.Age} , Role: {Role.Role1}";
            }
            private static void Main(string[] args)
            {
                Role myVar = Role.Role1;
                Console.WriteLine(myVar);

                StaffUser staff = new StaffUser() { Id = 101, Name = "Ahmad", Age = 20 };
                Console.WriteLine(staff.ToString());
                Console.ReadLine();
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

        }
    }
}
       
    

