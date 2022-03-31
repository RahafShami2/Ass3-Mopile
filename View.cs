using System;
using System.Collections.Generic;
using System.Text;
namespace Ass3Mo
{
    namespace Model
    {
        class View
        {
            //to show the changed when add/delete user 
            private static void AddView(User user)
            {
                Console.WriteLine($"user is added : {user}");
            }
            private static void RemoveView(User user)
            {
                Console.WriteLine($"user is removed : {user}");
            }

            public static void Main()
            {
                List<User> users = new List<User>();
                char anotherUser = 'N';
                //the user input Id,name ,age of "user" to add in list 
                do
                {
                    Console.WriteLine("\nPlease entre the Id:");
                    int userId = int.Parse(Console.ReadLine());
                    if (userId <= -1)
                    {
                        //invald execption 
                        throw new InvalidExecption("the id is invalid");
                    }
                    Console.WriteLine("\nPlease entre the name:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("\nPlease entre the age:");
                    int userAge = int.Parse(Console.ReadLine());
                    if (userAge <= 5)
                    {
                        //invald execption 
                        throw new InvalidExecption("the Age is invalid");
                    }
                    User user = new User(userId, userName, userAge);
                    if (userId == user.Id)
                    {
                        //execption
                        throw new DuplicateExecption("entre another id ");
                    }
                    //add user from input to the list
                    users.Add(user);
                    //if i want to add another user to list , if the user input "N/n" it will be stop
                    Console.Write("\nDo you want to create another User[Y/N]?: ");
                    anotherUser = char.ToUpper(Console.ReadKey(false).KeyChar);
                } while (anotherUser == 'Y');
                //to print the list 
                Console.WriteLine("\nList of users added:");
                foreach (User u in users)
                {
                    Console.WriteLine(u.Id + " " + u.Name + " " + u.Age);

                    int id = int.Parse(Console.ReadLine());
                    if (id != u.Id)
                    {
                        //execption
                        throw new NotFoundExecption("the id is not found");
                    }
                    //remove user by the id input 
                    if (id >= 0)
                    {
                        users.RemoveAt(id);
                    }
                }

              


                // make object from User to add/delete/edit user 
                User userList = new User();
                //implement and print "ToString" method
                Console.WriteLine(userList.ToString());
                userList.OnAdd += AddView;
                userList.OnRemove += RemoveView;


                //add three users by defult(not input) in the list
                userList.AddUser(new User(1, "Rahaf", 20));
                if (Id == users.Id)
                {
                    //execption
                    throw new DuplicateExecption("entre another id ");
                }
                userList.AddUser(new User(2, "Ali", 22));
                userList.AddUser(new User(3, "Rama", 19));

                Console.WriteLine("entre the user id you want to delete: ");
                int ID = int.Parse(Console.ReadLine());
                if (ID != u.Id)
                {
                    //execption
                    throw new NotFoundExecption("the id is not found");
                }
                //remove two user from the list 
                userList.RemoveUser(0);
                userList.RemoveUser(0);
                Console.ReadKey();

            }



            //to show the change in the screen
            public class ChangeModel
            {
                public event EventHandler<ChangeEventArgs> onChangeEvent;
                public void Changed(String change)
                {
                    Console.WriteLine($"Change made on the model classes {change}");

                    if (onChangeEvent != null)
                    {
                        onChangeEvent(this, new ChangeEventArgs(change));
                    }
                }
                public void DisplayNewChange(object sender, ChangeEventArgs ChangeEvent)
                {
                    ChangeModel ch = (ChangeModel)sender;
                    Console.WriteLine($"A new change {ChangeEvent.Change} from {ch}");
                }

            }
        }
        class ChangeEventArgs 
        {
            public string Change { get; set; }
            public ChangeEventArgs(string Change)
            {
                this.Change = Change;
            }
        }
    }

}
