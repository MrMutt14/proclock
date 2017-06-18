using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using ProcLock.Models;
using ProcLock.Providers;

namespace ProcLock
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            lbProc.DataSource = Process.GetProcesses().Select(p => new Proc()
            {
                Name = p.ProcessName,
                Title = p.MainWindowTitle,

                ID = p.Id
            }).OrderBy(p => p.Name).ToArray();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var toggle = btnAttach.Text == "Attach";
            
            lbProc.Enabled = !toggle;

            if (toggle)
            {
                tmrIdle.Start();
                btnAttach.Text = "Detach";
            }
            else
            {
                tmrIdle.Stop();
                btnAttach.Text = "Attach";
            }
        }

        private void tmrIdle_Tick(object sender, EventArgs e)
        {
            if (Idler.IdleTime() < nudIdle.Value * 1000)
                return;

            tmrIdle.Stop();

            var procID = ((Proc)lbProc.SelectedItem).ID;
            var frmLck = new frmLock(txtPIN.Text);

            ProcessProvider.Suspend(procID);

            this.Hide();
            frmLck.ShowDialog();

            ProcessProvider.Resume(procID);

            this.Show();
            tmrIdle.Start();
        }
    }
}