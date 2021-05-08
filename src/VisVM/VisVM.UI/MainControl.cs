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

using VisVM.UI.JsonViewer;

namespace VisVM.UI
{
    public partial class MainControl : Form
    {
        public static string GetDefaultBios(MachineProfile profile) => Path.Combine(profile.ProfileRoot, "bios", "bios.vbin");
        public MainControl()
        {
            StartupForm mc = new ();
            mc.ShowDialog();

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void LoadProfiles()
        {
            cb_Profile.Items.Clear();
            string[] p = Directory.GetFiles(MachineProfile.ProfileDirectory, "*.json");
            cb_Profile.Items.AddRange(p.Select(x => (object)Path.GetFileNameWithoutExtension(x)).ToArray());
            cb_Profile.SelectedIndex = 0;
        }

        public MachineProfile Create(string name, string root, string bios)
        {
            MachineProfile profile = new ()
                                     {
                                         BiosPath = bios,
                                         ProfileRoot = root,
                                         Name = name,
                                         StartArguments = "-cli:waitOnExit"
                                     };

            string content = MachineProfile.Save( profile );
            MessageBox.Show(
                            "Created Profile '" + profile.Name+"'\n"+ content,
                            "Profile Created!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                           );

            LoadProfiles();
            return profile;
        }

        private void CreateDefaultProfile()
        {
            string pPath = Path.Combine( MachineProfile.ProfileDirectory, "Default" );
            string bPath = Path.Combine(pPath,"bios", "bios.vhl");
            Create("Default", pPath, bPath);
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            string item = cb_Profile.SelectedItem.ToString();

            Machine m = Machine.Create(MachineProfile.GetByName(item));

            MachineInstance instance = m.CreateInstance();

            MachineInstanceControl instanceControl = new MachineInstanceControl( instance );
            instanceControl.Show();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string item = cb_Profile.SelectedItem.ToString();
            CreateProfileDialog diag = new CreateProfileDialog( MachineProfile.GetByName( item ) );

            if ( diag.ShowDialog() == DialogResult.OK )
            {
                MachineProfile.Save( diag.Profile );

                MessageBox.Show(
                                "Saved: " + diag.Profile.Name,
                                "Profile Saved!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                               );

                LoadProfiles();
            }
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            if (!MachineProfile.Exists("Default"))
            {
                CreateDefaultProfile();
            }
            LoadProfiles();
        }

        private void btn_OpenJson_Click(object sender, EventArgs e)
        {
            MachineProfile current = MachineProfile.GetByName(cb_Profile.SelectedItem.ToString());
            ofd_OpenJson.InitialDirectory = current.ProfileRoot;
            if ( ofd_OpenJson.ShowDialog() == DialogResult.OK )
                JsonViewerForm.CreateFromFile(  ofd_OpenJson.FileName ).ShowDialog();
        }

        private void btnRunWithBios_Click(object sender, EventArgs e)
        {
            string item = cb_Profile.SelectedItem.ToString();

            MachineProfile p = MachineProfile.GetByName( item );

            if ( ofdBios.ShowDialog() == DialogResult.OK )
            {
                p.BiosPath = ofdBios.FileName;
                Machine m = Machine.Create(p);

                MachineInstance instance = m.CreateInstance();

                MachineInstanceControl instanceControl = new MachineInstanceControl(instance);
                instanceControl.Show();
            }

           
        }
    }
}
