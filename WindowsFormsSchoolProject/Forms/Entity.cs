using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSchoolProject
{
    class Entity
    {
        public bool IsDatabaseAvailable()
        {
            school_windowsformsEntities1 entity = new school_windowsformsEntities1();
            return entity.Database.Exists();
        }

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

        public bool CreateUser(string username, string email)
        {
            using (school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                User user = new User();
                user.username = username;
                user.email = email;

                try
                {
                    entity.users.Add(user);
                    entity.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool DeleteUser(int id)
        {
            using (school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                //Find a user in the collection using Linq to SQL with a lambda expression.
                User user = entity.users.FirstOrDefault(x => x.id == id);

                try
                {
                    entity.users.Remove(user);
                    entity.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool EditUser(int id, string username, string email)
        {
            using (school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                //Find a user in the collection using Linq to SQL with a lambda expression.
                User user = entity.users.FirstOrDefault(x => x.id == id);

                user.username = username;
                user.email = email;

                try
                {
                    entity.users.Attach(user);

                    var entry = entity.Entry(user);
                    entry.Property(u => u.email).IsModified = true;
                    entry.Property(u => u.username).IsModified = true;
                    entity.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public void TruncateTable()
        {
            using (school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                var allUsers = GetAllUsers();

                foreach (var user in allUsers)
                {
                    DeleteUser(user.id);
                }
            }
        }

        public void PopulateTable(List<User> users)
        {
            using (school_windowsformsEntities1 entity = new school_windowsformsEntities1())
            {
                foreach (var user in users)
	            {
                    CreateUser(user.username, user.email);
	            }
            }
        }
    }
}
