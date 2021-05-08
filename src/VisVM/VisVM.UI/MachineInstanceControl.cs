using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisVM.UI
{
    public partial class MachineInstanceControl : Form
    {

        private MachineInstance m_Instance;
        private bool m_IgnoreClose;
        public MachineInstanceControl(MachineInstance instance)
        {
            InitializeComponent();
            SetInstance( instance );
        }

        private void SetInstance( MachineInstance instance )
        {
            m_Instance = instance;
            m_Instance.OnMachineExit += M_Instance_OnMachineExit; ;
            m_IgnoreClose = false;

            lblRoot.Text = "Root: " + instance.Profile.ProfileRoot;
            lbl_PID.Text = "PID: " + instance.PID;
            lbl_Profile.Text = "Profile: " + instance.Profile.Name;
            rtb_StartArgs.Text = instance.Profile.StartArguments;
        }

        private void M_Instance_OnMachineExit()
        {
            if(!m_IgnoreClose)
                Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            m_Instance.ForceShutdown();
        }

        private void btn_HardReset_Click(object sender, EventArgs e)
        {
            m_IgnoreClose = true;
            SetInstance(m_Instance.HardRestart());
        }

        private void btn_SoftReset_Click(object sender, EventArgs e)
        {
            m_IgnoreClose = true;
            SetInstance(m_Instance.SoftRestart());
        }

        private void cb_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = cb_TopMost.Checked;
        }
    }
}
