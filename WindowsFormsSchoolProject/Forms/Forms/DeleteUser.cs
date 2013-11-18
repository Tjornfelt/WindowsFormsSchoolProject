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
    public partial class DeleteUser : Form
    {
        bool databaseAvailable;
        public DeleteUser(bool dbAvailable)
        {
            databaseAvailable = dbAvailable;
            InitializeComponent();
        }

        private void btn_deleteUSer_Click(object sender, EventArgs e)
        {
            if (databaseAvailable)
            {
                Entity en = new Entity();
                en.DeleteUser(Convert.ToInt32(txt_deleteId.Text));
                XMLhelpers.SaveUsersToXml(en.GetAllUsers());
            }
            else
            {
                List<User> userList = XMLhelpers.FetchUsersFromXml();
                User deletedUser = userList.FirstOrDefault(x => x.id == Convert.ToInt32(txt_deleteId.Text));
                userList.Remove(deletedUser);
                XMLhelpers.SaveUsersToXml(userList);
            }
        }
    }
}