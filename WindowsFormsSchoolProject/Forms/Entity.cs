using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSchoolProject
{
    class Entity
    {
        public List<User> GetAllUsers()
        {
            using(school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                List<User> userList = new List<User>();
                foreach (User u in entity.users)
                {
                    userList.Add(u);
                }
                return userList;
            }
        }
    }
}
