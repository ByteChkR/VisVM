
namespace VisVM.UI
{
    partial class MachineInstanceControl
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Profile = new System.Windows.Forms.Label();
            this.lbl_PID = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.lbl_StartArgs = new System.Windows.Forms.Label();
            this.rtb_StartArgs = new System.Windows.Forms.RichTextBox();
            this.btn_HardReset = new System.Windows.Forms.Button();
            this.btn_SoftReset = new System.Windows.Forms.Button();
            this.cb_TopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 258);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(247, 23);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Profile
            // 
            this.lbl_Profile.AutoSize = true;
            this.lbl_Profile.Location = new System.Drawing.Point(12, 13);
            this.lbl_Profile.Name = "lbl_Profile";
            this.lbl_Profile.Size = new System.Drawing.Size(39, 13);
            this.lbl_Profile.TabIndex = 1;
            this.lbl_Profile.Text = "Profile:";
            // 
            // lbl_PID
            // 
            this.lbl_PID.AutoSize = true;
            this.lbl_PID.Location = new System.Drawing.Point(12, 40);
            this.lbl_PID.Name = "lbl_PID";
            this.lbl_PID.Size = new System.Drawing.Size(28, 13);
            this.lbl_PID.TabIndex = 2;
            this.lbl_PID.Text = "PID:";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(12, 67);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(33, 13);
            this.lblRoot.TabIndex = 3;
            this.lblRoot.Text = "Root:";
            // 
            // lbl_StartArgs
            // 
            this.lbl_StartArgs.AutoSize = true;
            this.lbl_StartArgs.Location = new System.Drawing.Point(12, 96);
            this.lbl_StartArgs.Name = "lbl_StartArgs";
            this.lbl_StartArgs.Size = new System.Drawing.Size(56, 13);
            this.lbl_StartArgs.TabIndex = 4;
            this.lbl_StartArgs.Text = "Start Args:";
            // 
            // rtb_StartArgs
            // 
            this.rtb_StartArgs.Location = new System.Drawing.Point(12, 112);
            this.rtb_StartArgs.Name = "rtb_StartArgs";
            this.rtb_StartArgs.ReadOnly = true;
            this.rtb_StartArgs.Size = new System.Drawing.Size(247, 82);
            this.rtb_StartArgs.TabIndex = 5;
            this.rtb_StartArgs.Text = "";
            // 
            // btn_HardReset
            // 
            this.btn_HardReset.Location = new System.Drawing.Point(12, 229);
            this.btn_HardReset.Name = "btn_HardReset";
            this.btn_HardReset.Size = new System.Drawing.Size(247, 23);
            this.btn_HardReset.TabIndex = 6;
            this.btn_HardReset.Text = "Hard Reset";
            this.btn_HardReset.UseVisualStyleBackColor = true;
            this.btn_HardReset.Click += new System.EventHandler(this.btn_HardReset_Click);
            // 
            // btn_SoftReset
            // 
            this.btn_SoftReset.Location = new System.Drawing.Point(12, 200);
            this.btn_SoftReset.Name = "btn_SoftReset";
            this.btn_SoftReset.Size = new System.Drawing.Size(247, 23);
            this.btn_SoftReset.TabIndex = 7;
            this.btn_SoftReset.Text = "Soft Reset";
            this.btn_SoftReset.UseVisualStyleBackColor = true;
            this.btn_SoftReset.Click += new System.EventHandler(this.btn_SoftReset_Click);
            // 
            // cb_TopMost
            // 
            this.cb_TopMost.AutoSize = true;
            this.cb_TopMost.Location = new System.Drawing.Point(179, 12);
            this.cb_TopMost.Name = "cb_TopMost";
            this.cb_TopMost.Size = new System.Drawing.Size(71, 17);
            this.cb_TopMost.TabIndex = 8;
            this.cb_TopMost.Text = "Top Most";
            this.cb_TopMost.UseVisualStyleBackColor = true;
            this.cb_TopMost.CheckedChanged += new System.EventHandler(this.cb_TopMost_CheckedChanged);
            // 
            // MachineInstanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 284);
            this.Controls.Add(this.cb_TopMost);
            this.Controls.Add(this.btn_SoftReset);
            this.Controls.Add(this.btn_HardReset);
            this.Controls.Add(this.rtb_StartArgs);
            this.Controls.Add(this.lbl_StartArgs);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.lbl_PID);
            this.Controls.Add(this.lbl_Profile);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MachineInstanceControl";
            this.Text = "MachineInstanceControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Profile;
        private System.Windows.Forms.Label lbl_PID;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Label lbl_StartArgs;
        private System.Windows.Forms.RichTextBox rtb_StartArgs;
        private System.Windows.Forms.Button btn_HardReset;
        private System.Windows.Forms.Button btn_SoftReset;
        private System.Windows.Forms.CheckBox cb_TopMost;
    }
}