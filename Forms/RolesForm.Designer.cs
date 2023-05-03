
namespace UsersManagement.Forms
{
    partial class RolesForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.titleTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxb = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInformationToolStripMenuItem,
            this.SaveBtn,
            this.DeleteBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveInformationToolStripMenuItem
            // 
            this.saveInformationToolStripMenuItem.Name = "saveInformationToolStripMenuItem";
            this.saveInformationToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saveInformationToolStripMenuItem.Text = "Close";
            this.saveInformationToolStripMenuItem.Click += new System.EventHandler(this.saveInformationToolStripMenuItem_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 20);
            this.SaveBtn.Text = "Save Information";
            this.SaveBtn.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(52, 20);
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // titleTxb
            // 
            this.titleTxb.Location = new System.Drawing.Point(128, 61);
            this.titleTxb.Name = "titleTxb";
            this.titleTxb.Size = new System.Drawing.Size(254, 20);
            this.titleTxb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rol Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // descriptionTxb
            // 
            this.descriptionTxb.Location = new System.Drawing.Point(130, 99);
            this.descriptionTxb.Multiline = true;
            this.descriptionTxb.Name = "descriptionTxb";
            this.descriptionTxb.Size = new System.Drawing.Size(254, 127);
            this.descriptionTxb.TabIndex = 1;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RolesForm";
            this.Text = "Role Information";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveBtn;
        private System.Windows.Forms.ToolStripMenuItem DeleteBtn;
        private System.Windows.Forms.TextBox titleTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTxb;
    }
}