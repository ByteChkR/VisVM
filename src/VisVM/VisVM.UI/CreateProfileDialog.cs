using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisVM.UI
{
    public partial class CreateProfileDialog : Form
    {

        public MachineProfile Profile;
        public CreateProfileDialog(MachineProfile machineProfile)
        {
            Profile = machineProfile;
            InitializeComponent();
        }
        

        private void CreateProfileDialog_Load(object sender, EventArgs e)
        {
            rtb_StartArgs.Text = Profile.StartArguments;
            tb_BiosPath.Text = Profile.BiosPath;
            tb_Name.Text = Profile.Name;
            tb_RootPath.Text = Profile.ProfileRoot;
            tb_Name.TextChanged += NameChanged;
            tb_BiosPath.TextChanged += BiosPathChanged;
            rtb_StartArgs.TextChanged += StartArgsChanged;
        }

        private void StartArgsChanged(object sender, EventArgs e)
        {
            Profile.StartArguments = rtb_StartArgs.Text;
        }

        private void BiosPathChanged(object sender, EventArgs e)
        {
            Profile.BiosPath = tb_BiosPath.Text;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            Profile.ProfileRoot = tb_RootPath.Text = Path.Combine( MachineProfile.ProfileDirectory, tb_Name.Text );
            Profile.Name = tb_Name.Text;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBrowseBios_Click(object sender, EventArgs e)
        {
            if ( ofd_BiosFile.ShowDialog() == DialogResult.OK )
            {
                tb_BiosPath.Text = ofd_BiosFile.FileName;
            }
        }
    }
}
