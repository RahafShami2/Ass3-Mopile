using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ass3Mo
{
    namespace Model {
        class ViewModel
        {


            //make empty list to add user ..
            private List<User> users = null;
            public delegate void UserDelegate(User user);
            public event UserDelegate OnAdd;
            public event UserDelegate OnRemove;
            //function add user to list
            public void AddUser(User user)
            {
                users.Add(user);
                if (OnAdd != null)
                {
                    OnAdd(user);
                }
            }
            //function delete the user (who the id input = id user) from the list
            public void RemoveUser(int index)
            {
                if (OnRemove != null)
                {
                    User user = users[index];
                    OnRemove(user);
                }
                users.RemoveAt(index);
            }
            //function to edit the user info
            public void Edit(int id)
            {
                users.Find(p => p.userId == id).FieldToModify = newValueForTheFIeld;
            }
        }
     
    }
}