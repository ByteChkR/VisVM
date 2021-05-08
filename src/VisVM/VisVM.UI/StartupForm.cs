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
    public partial class StartupForm : Form
    {

        private Task m_InitTask;
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            m_InitTask = Task.Run(Machine.InitializeCore);
            tmr_Startup.Start();
        }

        private void tmr_Startup_Tick(object sender, EventArgs e)
        {
            if (m_InitTask.IsCanceled || m_InitTask.IsFaulted)
            {
                tmr_Startup.Stop();
                lbl_Loading.ForeColor = Color.Red;
                lbl_Loading.Text = "Error..";
            }
            else if ( m_InitTask.IsCompleted )
            {
                tmr_Startup.Stop();
                Close();
            }
        }
    }
}
