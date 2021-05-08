
namespace VisVM.UI
{
    partial class CreateProfileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_ProfileName = new System.Windows.Forms.Label();
            this.lbl_RootDir = new System.Windows.Forms.Label();
            this.tb_RootPath = new System.Windows.Forms.TextBox();
            this.lbl_BiosPath = new System.Windows.Forms.Label();
            this.tb_BiosPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBios = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.ofd_BiosFile = new System.Windows.Forms.OpenFileDialog();
            this.lblArguments = new System.Windows.Forms.Label();
            this.rtb_StartArgs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(98, 13);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(439, 20);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.Text = "NewProfile";
            // 
            // lbl_ProfileName
            // 
            this.lbl_ProfileName.AutoSize = true;
            this.lbl_ProfileName.Location = new System.Drawing.Point(12, 16);
            this.lbl_ProfileName.Name = "lbl_ProfileName";
            this.lbl_ProfileName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ProfileName.TabIndex = 1;
            this.lbl_ProfileName.Text = "Name";
            // 
            // lbl_RootDir
            // 
            this.lbl_RootDir.AutoSize = true;
            this.lbl_RootDir.Location = new System.Drawing.Point(12, 46);
            this.lbl_RootDir.Name = "lbl_RootDir";
            this.lbl_RootDir.Size = new System.Drawing.Size(75, 13);
            this.lbl_RootDir.TabIndex = 2;
            this.lbl_RootDir.Text = "Root Directory";
            // 
            // tb_RootPath
            // 
            this.tb_RootPath.Location = new System.Drawing.Point(98, 43);
            this.tb_RootPath.Name = "tb_RootPath";
            this.tb_RootPath.ReadOnly = true;
            this.tb_RootPath.Size = new System.Drawing.Size(439, 20);
            this.tb_RootPath.TabIndex = 3;
            this.tb_RootPath.Text = "<directory>";
            // 
            // lbl_BiosPath
            // 
            this.lbl_BiosPath.AutoSize = true;
            this.lbl_BiosPath.Location = new System.Drawing.Point(12, 75);
            this.lbl_BiosPath.Name = "lbl_BiosPath";
            this.lbl_BiosPath.Size = new System.Drawing.Size(57, 13);
            this.lbl_BiosPath.TabIndex = 4;
            this.lbl_BiosPath.Text = "BIOS Path";
            // 
            // tb_BiosPath
            // 
            this.tb_BiosPath.Location = new System.Drawing.Point(98, 72);
            this.tb_BiosPath.Name = "tb_BiosPath";
            this.tb_BiosPath.Size = new System.Drawing.Size(403, 20);
            this.tb_BiosPath.TabIndex = 5;
            this.tb_BiosPath.Text = "<bios-path>";
            // 
            // btnBrowseBios
            // 
            this.btnBrowseBios.Location = new System.Drawing.Point(507, 70);
            this.btnBrowseBios.Name = "btnBrowseBios";
            this.btnBrowseBios.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseBios.TabIndex = 6;
            this.btnBrowseBios.Text = "...";
            this.btnBrowseBios.UseVisualStyleBackColor = true;
            this.btnBrowseBios.Click += new System.EventHandler(this.btnBrowseBios_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(12, 169);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(525, 23);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // ofd_BiosFile
            // 
            this.ofd_BiosFile.DefaultExt = "vhl";
            this.ofd_BiosFile.FileName = "bios";
            this.ofd_BiosFile.Filter = "Vis Binary|*.vbin|Vis Binary|*.vbin.z";
            this.ofd_BiosFile.Title = "Select Bios Image";
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(12, 103);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(57, 13);
            this.lblArguments.TabIndex = 8;
            this.lblArguments.Text = "Arguments";
            // 
            // rtb_StartArgs
            // 
            this.rtb_StartArgs.Location = new System.Drawing.Point(98, 100);
            this.rtb_StartArgs.Name = "rtb_StartArgs";
            this.rtb_StartArgs.Size = new System.Drawing.Size(439, 63);
            this.rtb_StartArgs.TabIndex = 9;
            this.rtb_StartArgs.Text = "";
            // 
            // CreateProfileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 204);
            this.Controls.Add(this.rtb_StartArgs);
            this.Controls.Add(this.lblArguments);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btnBrowseBios);
            this.Controls.Add(this.tb_BiosPath);
            this.Controls.Add(this.lbl_BiosPath);
            this.Controls.Add(this.tb_RootPath);
            this.Controls.Add(this.lbl_RootDir);
            this.Controls.Add(this.lbl_ProfileName);
            this.Controls.Add(this.tb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProfileDialog";
            this.Text = "CreateProfileDialog";
            this.Load += new System.EventHandler(this.CreateProfileDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_ProfileName;
        private System.Windows.Forms.Label lbl_RootDir;
        private System.Windows.Forms.TextBox tb_RootPath;
        private System.Windows.Forms.Label lbl_BiosPath;
        private System.Windows.Forms.TextBox tb_BiosPath;
        private System.Windows.Forms.Button btnBrowseBios;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.OpenFileDialog ofd_BiosFile;
        private System.Windows.Forms.Label lblArguments;
        private System.Windows.Forms.RichTextBox rtb_StartArgs;
    }
}