using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSchoolProject.Forms
{
    public partial class MDIparent : Form
    {
        public MDIparent()
        {
            InitializeComponent();
        }

        private void MDIparent_Load(object sender, EventArgs e)
        {
            MDIchild mdiChild = new MDIchild();

            mdiChild.MdiParent = this;

            mdiChild.Show();
        }
    }
}
