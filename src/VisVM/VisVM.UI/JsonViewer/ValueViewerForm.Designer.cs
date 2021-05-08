
namespace VisVM.UI.JsonViewer
{
    partial class ValueViewerForm
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
            this.lbl_PropertyName = new System.Windows.Forms.Label();
            this.panel_PropertyName = new System.Windows.Forms.Panel();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_Value = new System.Windows.Forms.Panel();
            this.rtb_Value = new System.Windows.Forms.RichTextBox();
            this.panel_PropertyName.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.panel_Value.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PropertyName
            // 
            this.lbl_PropertyName.AutoSize = true;
            this.lbl_PropertyName.Location = new System.Drawing.Point(12, 9);
            this.lbl_PropertyName.Name = "lbl_PropertyName";
            this.lbl_PropertyName.Size = new System.Drawing.Size(35, 13);
            this.lbl_PropertyName.TabIndex = 0;
            this.lbl_PropertyName.Text = "Name";
            // 
            // panel_PropertyName
            // 
            this.panel_PropertyName.Controls.Add(this.lbl_PropertyName);
            this.panel_PropertyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PropertyName.Location = new System.Drawing.Point(0, 0);
            this.panel_PropertyName.Name = "panel_PropertyName";
            this.panel_PropertyName.Size = new System.Drawing.Size(463, 32);
            this.panel_PropertyName.TabIndex = 2;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btn_Save);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 179);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(463, 32);
            this.panel_Buttons.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(385, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel_Value
            // 
            this.panel_Value.Controls.Add(this.rtb_Value);
            this.panel_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Value.Location = new System.Drawing.Point(0, 32);
            this.panel_Value.Name = "panel_Value";
            this.panel_Value.Size = new System.Drawing.Size(463, 147);
            this.panel_Value.TabIndex = 4;
            // 
            // rtb_Value
            // 
            this.rtb_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Value.Location = new System.Drawing.Point(0, 0);
            this.rtb_Value.Name = "rtb_Value";
            this.rtb_Value.Size = new System.Drawing.Size(463, 147);
            this.rtb_Value.TabIndex = 0;
            this.rtb_Value.Text = "";
            // 
            // ValueViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 211);
            this.Controls.Add(this.panel_Value);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_PropertyName);
            this.Name = "ValueViewerForm";
            this.Text = "ValueViewerForm";
            this.panel_PropertyName.ResumeLayout(false);
            this.panel_PropertyName.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.panel_Value.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_PropertyName;
        private System.Windows.Forms.Panel panel_PropertyName;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel_Value;
        private System.Windows.Forms.RichTextBox rtb_Value;
    }
}