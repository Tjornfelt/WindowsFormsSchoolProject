using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace WindowsFormsSchoolProject.CustomControls
{
    //Create a new class which inherits from Button
    class SuperButton : Button
    {
        private bool isSuper = true;

        //Create a new property.
        [Description("Gets or sets whether or not the control is super")]
        [Category("Super Stuff")]
        [DefaultValue(true)]
        public bool IsSuper
        {
            get { return isSuper; }
            set { isSuper = value; }
        }

        //Override OnMouseEnter to give this custom control a unique function.
        protected override void OnMouseEnter(EventArgs e)
        {
            if (IsSuper)
            {
                this.Size = new System.Drawing.Size(150, 150);
                base.OnMouseEnter(e);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (IsSuper)
            {
                this.Size = new System.Drawing.Size(100, 35);
                base.OnMouseLeave(e);
            }
        }
    }
}
