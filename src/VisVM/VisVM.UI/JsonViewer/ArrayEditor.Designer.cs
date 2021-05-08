
namespace VisVM.UI.JsonViewer
{
    partial class ArrayEditor
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
            this.lb_Array = new System.Windows.Forms.CheckedListBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel_ArrayList = new System.Windows.Forms.Panel();
            this.btn_Duplicate = new System.Windows.Forms.Button();
            this.panel_Buttons.SuspendLayout();
            this.panel_ArrayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Array
            // 
            this.lb_Array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Array.FormattingEnabled = true;
            this.lb_Array.Location = new System.Drawing.Point(0, 0);
            this.lb_Array.Name = "lb_Array";
            this.lb_Array.Size = new System.Drawing.Size(517, 216);
            this.lb_Array.TabIndex = 0;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btn_Duplicate);
            this.panel_Buttons.Controls.Add(this.btn_Remove);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 216);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(517, 32);
            this.panel_Buttons.TabIndex = 1;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.Location = new System.Drawing.Point(422, 3);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(83, 23);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // panel_ArrayList
            // 
            this.panel_ArrayList.Controls.Add(this.lb_Array);
            this.panel_ArrayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ArrayList.Location = new System.Drawing.Point(0, 0);
            this.panel_ArrayList.Name = "panel_ArrayList";
            this.panel_ArrayList.Size = new System.Drawing.Size(517, 216);
            this.panel_ArrayList.TabIndex = 2;
            // 
            // btn_Duplicate
            // 
            this.btn_Duplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Duplicate.Location = new System.Drawing.Point(333, 3);
            this.btn_Duplicate.Name = "btn_Duplicate";
            this.btn_Duplicate.Size = new System.Drawing.Size(83, 23);
            this.btn_Duplicate.TabIndex = 1;
            this.btn_Duplicate.Text = "Duplicate";
            this.btn_Duplicate.UseVisualStyleBackColor = true;
            this.btn_Duplicate.Click += new System.EventHandler(this.btn_Duplicate_Click);
            // 
            // ArrayEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 248);
            this.Controls.Add(this.panel_ArrayList);
            this.Controls.Add(this.panel_Buttons);
            this.Name = "ArrayEditor";
            this.Text = "ArrayEditor";
            this.panel_Buttons.ResumeLayout(false);
            this.panel_ArrayList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lb_Array;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Panel panel_ArrayList;
        private System.Windows.Forms.Button btn_Duplicate;
    }
}