using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsSchoolProject.Helpers;

namespace WindowsFormsSchoolProject.Forms
{
    public partial class CreateUser : Form
    {
        bool databaseAvailable;
        public CreateUser(bool dbAvailable)
        {
            databaseAvailable = dbAvailable;
            InitializeComponent();
        }

        private void createUserOk_Click(object sender, EventArgs e)
        {
            //If the database is available, save the data directly to the database
            if (databaseAvailable)
            {
                Entity en = new Entity();

                if (en.CreateUser(txt_username.Text, txt_email.Text))
                {
                    MessageBox.Show("User succesfully created!");
                    XMLhelpers.SaveUsersToXml(en.GetAllUsers());
                }
                else
                {
                    MessageBox.Show("Failed to create user");
                }
                //TODO add stuff!
            }
            else
            {
                //If the database is NOT available, save the data to the XML document.
                List<User> userList = XMLhelpers.FetchUsersFromXml();

                int nextId = 0;

                foreach (var user in userList)
                {
                    if (user.id > nextId)
                    {
                        nextId = user.id;
                    }                    
                }
                nextId++;

                User newUser = new User();
                newUser.email = txt_email.Text;
                newUser.username = txt_username.Text;
                newUser.id = nextId;

                userList.Add(newUser);
                XMLhelpers.SaveUsersToXml(userList);
            }
        }
    }
}
