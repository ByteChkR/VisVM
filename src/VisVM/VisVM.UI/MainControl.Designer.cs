
namespace VisVM.UI
{
    partial class MainControl
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
            this.btn_Run = new System.Windows.Forms.Button();
            this.cb_Profile = new System.Windows.Forms.ComboBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_OpenJson = new System.Windows.Forms.Button();
            this.ofd_OpenJson = new System.Windows.Forms.OpenFileDialog();
            this.btnRunWithBios = new System.Windows.Forms.Button();
            this.ofdBios = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(12, 39);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // cb_Profile
            // 
            this.cb_Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Profile.FormattingEnabled = true;
            this.cb_Profile.Location = new System.Drawing.Point(12, 12);
            this.cb_Profile.Name = "cb_Profile";
            this.cb_Profile.Size = new System.Drawing.Size(776, 21);
            this.cb_Profile.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(192, 39);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_OpenJson
            // 
            this.btn_OpenJson.Location = new System.Drawing.Point(708, 39);
            this.btn_OpenJson.Name = "btn_OpenJson";
            this.btn_OpenJson.Size = new System.Drawing.Size(80, 23);
            this.btn_OpenJson.TabIndex = 4;
            this.btn_OpenJson.Text = "Open Json";
            this.btn_OpenJson.UseVisualStyleBackColor = true;
            this.btn_OpenJson.Click += new System.EventHandler(this.btn_OpenJson_Click);
            // 
            // ofd_OpenJson
            // 
            this.ofd_OpenJson.DefaultExt = "json";
            this.ofd_OpenJson.FileName = "config.json";
            this.ofd_OpenJson.Filter = "JSON Files|*.json";
            this.ofd_OpenJson.Title = "Open Json File";
            // 
            // btnRunWithBios
            // 
            this.btnRunWithBios.Location = new System.Drawing.Point(93, 39);
            this.btnRunWithBios.Name = "btnRunWithBios";
            this.btnRunWithBios.Size = new System.Drawing.Size(93, 23);
            this.btnRunWithBios.TabIndex = 5;
            this.btnRunWithBios.Text = "Run With BIOS";
            this.btnRunWithBios.UseVisualStyleBackColor = true;
            this.btnRunWithBios.Click += new System.EventHandler(this.btnRunWithBios_Click);
            // 
            // ofdBios
            // 
            this.ofdBios.DefaultExt = "vbin";
            this.ofdBios.FileName = "bios.vbin";
            this.ofdBios.Filter = "Vis Binaries|*.vbin|Vis Binaries|*.vbin.z";
            this.ofdBios.Title = "Select \"One-Time\" Bios";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 70);
            this.Controls.Add(this.btnRunWithBios);
            this.Controls.Add(this.btn_OpenJson);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.cb_Profile);
            this.Controls.Add(this.btn_Run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainControl";
            this.Text = "MainControl";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.ComboBox cb_Profile;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_OpenJson;
        private System.Windows.Forms.OpenFileDialog ofd_OpenJson;
        private System.Windows.Forms.Button btnRunWithBios;
        private System.Windows.Forms.OpenFileDialog ofdBios;
    }
}