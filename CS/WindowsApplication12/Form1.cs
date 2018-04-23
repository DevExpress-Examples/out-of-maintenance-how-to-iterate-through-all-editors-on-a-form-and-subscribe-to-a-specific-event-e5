using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessAllEditors(this);
        }

        private void ProcessAllEditors(Control container)
        {
            if (container is BaseEdit)
                //subscribe to the current control's events
                container.GotFocus += new EventHandler(c_GotFocus);
            else
                //process all child controls recursively
                foreach (Control c in container.Controls)
                    ProcessAllEditors(c);
        }

        void c_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextEdit)
                (sender as TextEdit).SelectAll();
        }
    }
}