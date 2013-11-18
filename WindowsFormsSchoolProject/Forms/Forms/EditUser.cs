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
    public partial class EditUser : Form
    {
        bool databaseAvailable;
        public EditUser(bool dbAvailable)
        {
            databaseAvailable = dbAvailable;
            InitializeComponent();
        }

        private void btn_editUserOk_Click(object sender, EventArgs e)
        {
            if (databaseAvailable)
            {
                Entity en = new Entity();
                en.EditUser(Convert.ToInt32(txt_editUserId.Text), txt_editUsername.Text, txt_editEmail.Text);
                XMLhelpers.SaveUsersToXml(en.GetAllUsers());
            }
            else
            {
                List<User> userList = XMLhelpers.FetchUsersFromXml();

                //Update the item in the list.
                User userToEdit = userList.FirstOrDefault(x => x.id == Convert.ToInt32(txt_editUserId.Text));
                userToEdit.username = txt_editUsername.Text;
                userToEdit.email = txt_editEmail.Text;

                XMLhelpers.SaveUsersToXml(userList);
            }
        }
    }
}