
namespace UsersManagement.Forms
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxbUserName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TxbUserName
            // 
            this.TxbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbUserName.Location = new System.Drawing.Point(53, 229);
            this.TxbUserName.Name = "TxbUserName";
            this.TxbUserName.Size = new System.Drawing.Size(304, 26);
            this.TxbUserName.TabIndex = 0;
            this.TxbUserName.Text = "ali.cruz";
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
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxbUserName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxbPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 480);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::UsersManagement.Properties.Resources.ventanas;
            this.pictureBox1.Location = new System.Drawing.Point(53, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TxbPassword.Location = new System.Drawing.Point(53, 309);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(304, 26);
            this.TxbPassword.TabIndex = 1;
            this.TxbPassword.Text = "holahola";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnExitApp);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Location = new System.Drawing.Point(53, 363);
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
            this.BtnExitApp.TabIndex = 3;
            this.BtnExitApp.Text = "Exit";
            this.BtnExitApp.UseVisualStyleBackColor = true;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Image = global::UsersManagement.Properties.Resources.log_in;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(5, 6);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(131, 52);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbUserName;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExitApp;
    }
}