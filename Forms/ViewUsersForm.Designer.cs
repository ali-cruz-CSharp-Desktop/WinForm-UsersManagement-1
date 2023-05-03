
namespace UsersManagement.Forms
{
    partial class ViewUsersForm
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refresRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.UsersDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newUserToolStripMenuItem,
            this.toolStripMenuItem2,
            this.refresRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // refresRecordsToolStripMenuItem
            // 
            this.refresRecordsToolStripMenuItem.Name = "refresRecordsToolStripMenuItem";
            this.refresRecordsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.refresRecordsToolStripMenuItem.Text = "Refres Records";
            this.refresRecordsToolStripMenuItem.Click += new System.EventHandler(this.refresRecordsToolStripMenuItem_Click);
            // 
            // SearchTxb
            // 
            this.SearchTxb.Location = new System.Drawing.Point(130, 59);
            this.SearchTxb.Name = "SearchTxb";
            this.SearchTxb.Size = new System.Drawing.Size(491, 20);
            this.SearchTxb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by User Name:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SearchBtn.Image = global::UsersManagement.Properties.Resources.search__3_;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchBtn.Location = new System.Drawing.Point(625, 47);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 42);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UsersDGV
            // 
            this.UsersDGV.AllowUserToAddRows = false;
            this.UsersDGV.AllowUserToDeleteRows = false;
            this.UsersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDGV.Location = new System.Drawing.Point(11, 114);
            this.UsersDGV.Name = "UsersDGV";
            this.UsersDGV.ReadOnly = true;
            this.UsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDGV.Size = new System.Drawing.Size(854, 379);
            this.UsersDGV.TabIndex = 5;
            this.UsersDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDGV_CellDoubleClick);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.SearchTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.UsersDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewUsersForm";
            this.Text = "View Users Form";
            this.Activated += new System.EventHandler(this.ViewUsersForm_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refresRecordsToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView UsersDGV;
    }
}