using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Ass3Mo
{
    namespace Model
    {
        public class User
        {
            //getter && setter of variable {Id , name , age}
            public int Id { get; set; }
            public string Name { get; set; }
            public float Age { get; set; }
            public User(int id, string Name, int Age)
            {
                this.Id = id;
                this.Name = Name;
                this.Age = Age;
            }

            public User()
            {
            }

            //Override the "ToString" method to print all details inside the method
            public override string ToString()
            {
                return $"Id: {this.Id} , Name: {this.Name} , Age: {this.Age}";
            }

            //Override the "Equals" method  to compare the object based on the data
            public bool Equals(User u)
            {
                if (u is null)
                {
                    return false;
                }
                if (Object.ReferenceEquals(this, u))
                {
                    return true;
                }
                if (u.Id == Id && u.Name == Name && u.Age == Age)
                {
                    return base.Equals(Id);
                }
                else
                {
                    return false;
                }

            }
            //implement the method
            public override bool Equals(object obj) => this.Equals(obj);

        }
    }
}

    

