
namespace UsersManagement.Forms
{
    partial class ChangePasswordForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbOldPassord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbNewPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxbOldPassord, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxbNewPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxbConfirmPassword, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 334);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TxbOldPassord
            // 
            this.TxbOldPassord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbOldPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbOldPassord.Location = new System.Drawing.Point(53, 29);
            this.TxbOldPassord.Name = "TxbOldPassord";
            this.TxbOldPassord.Size = new System.Drawing.Size(304, 26);
            this.TxbOldPassord.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TxbNewPassword
            // 
            this.TxbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbNewPassword.Location = new System.Drawing.Point(53, 109);
            this.TxbNewPassword.Name = "TxbNewPassword";
            this.TxbNewPassword.Size = new System.Drawing.Size(304, 26);
            this.TxbNewPassword.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnExitApp);
            this.panel1.Controls.Add(this.BtnChangePassword);
            this.panel1.Location = new System.Drawing.Point(53, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 64);
            this.panel1.TabIndex = 6;
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.Image = global::UsersManagement.Properties.Resources.exit;
            this.BtnExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExitApp.Location = new System.Drawing.Point(167, 6);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(131, 52);
            this.BtnExitApp.TabIndex = 4;
            this.BtnExitApp.Text = "Close";
            this.BtnExitApp.UseVisualStyleBackColor = true;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Image = global::UsersManagement.Properties.Resources.log_in;
            this.BtnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChangePassword.Location = new System.Drawing.Point(5, 6);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(131, 52);
            this.BtnChangePassword.TabIndex = 3;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TxbConfirmPassword
            // 
            this.TxbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbConfirmPassword.Location = new System.Drawing.Point(53, 189);
            this.TxbConfirmPassword.Name = "TxbConfirmPassword";
            this.TxbConfirmPassword.Size = new System.Drawing.Size(304, 26);
            this.TxbConfirmPassword.TabIndex = 2;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbOldPassord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbNewPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExitApp;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbConfirmPassword;
    }
}