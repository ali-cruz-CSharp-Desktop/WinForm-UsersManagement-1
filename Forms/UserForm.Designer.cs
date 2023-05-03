
namespace UsersManagement.Forms
{
    partial class UserForm
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.rolescb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TexBDescripcion = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveInformationToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.closeToolStripMenuItem.Text = "Close |";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveInformationToolStripMenuItem
            // 
            this.saveInformationToolStripMenuItem.Name = "saveInformationToolStripMenuItem";
            this.saveInformationToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.saveInformationToolStripMenuItem.Text = "Save Information |";
            this.saveInformationToolStripMenuItem.Click += new System.EventHandler(this.saveInformationToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // TxbUserName
            // 
            this.TxbUserName.Location = new System.Drawing.Point(117, 80);
            this.TxbUserName.Name = "TxbUserName";
            this.TxbUserName.Size = new System.Drawing.Size(318, 20);
            this.TxbUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(117, 115);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(317, 20);
            this.TxbPassword.TabIndex = 6;
            // 
            // rolescb
            // 
            this.rolescb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolescb.FormattingEnabled = true;
            this.rolescb.Location = new System.Drawing.Point(116, 165);
            this.rolescb.Name = "rolescb";
            this.rolescb.Size = new System.Drawing.Size(171, 21);
            this.rolescb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // TexBDescripcion
            // 
            this.TexBDescripcion.Location = new System.Drawing.Point(118, 204);
            this.TexBDescripcion.Multiline = true;
            this.TexBDescripcion.Name = "TexBDescripcion";
            this.TexBDescripcion.Size = new System.Drawing.Size(316, 87);
            this.TexBDescripcion.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(343, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Is active user";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 316);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TexBDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rolescb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.ComboBox rolescb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TexBDescripcion;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}