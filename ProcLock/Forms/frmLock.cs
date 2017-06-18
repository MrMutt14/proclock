using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProcLock
{
    public partial class frmLock : Form
    {
        private string _pin;

        public frmLock(string pin)
        {
            InitializeComponent();

            _pin = pin;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtPIN.Text == _pin)
                this.Close();
        }
    }
}
