
namespace VisVM.UI.JsonViewer
{
    partial class JsonViewerForm
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
            this.tvTree = new System.Windows.Forms.TreeView();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_Tree = new System.Windows.Forms.Panel();
            this.sfd_JsonFile = new System.Windows.Forms.SaveFileDialog();
            this.panel_Buttons.SuspendLayout();
            this.panel_Tree.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvTree
            // 
            this.tvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTree.Location = new System.Drawing.Point(0, 0);
            this.tvTree.Name = "tvTree";
            this.tvTree.Size = new System.Drawing.Size(541, 490);
            this.tvTree.TabIndex = 1;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.btn_Save);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(0, 490);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(541, 41);
            this.panel_Buttons.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(463, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 32);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel_Tree
            // 
            this.panel_Tree.Controls.Add(this.tvTree);
            this.panel_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Tree.Location = new System.Drawing.Point(0, 0);
            this.panel_Tree.Name = "panel_Tree";
            this.panel_Tree.Size = new System.Drawing.Size(541, 490);
            this.panel_Tree.TabIndex = 3;
            // 
            // sfd_JsonFile
            // 
            this.sfd_JsonFile.DefaultExt = "json";
            this.sfd_JsonFile.FileName = "config.json";
            this.sfd_JsonFile.Filter = "JSON Files|*.json";
            // 
            // JsonViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 531);
            this.Controls.Add(this.panel_Tree);
            this.Controls.Add(this.panel_Buttons);
            this.Name = "JsonViewerForm";
            this.Text = "JsonViewerForm";
            this.panel_Buttons.ResumeLayout(false);
            this.panel_Tree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvTree;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel_Tree;
        private System.Windows.Forms.SaveFileDialog sfd_JsonFile;
    }
}