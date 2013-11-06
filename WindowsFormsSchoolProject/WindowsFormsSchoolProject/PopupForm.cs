using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSchoolProject
{
    public partial class PopupForm : Form
    {
        public string fileName {get;set;}

        public PopupForm()
        {
            InitializeComponent();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {

        }

        private void pFileName_TextChanged(object sender, EventArgs e)
        {
            fileName = @"\" + pFileName.Text + ".txt";
        }
    }
}
