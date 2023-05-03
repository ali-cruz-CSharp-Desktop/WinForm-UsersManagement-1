
namespace UsersManagement.Forms
{
    partial class ViewRolesForm
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
            this.newRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.newRoleToolStripMenuItem,
            this.refreshRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.closeToolStripMenuItem.Text = "Close |";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // newRoleToolStripMenuItem
            // 
            this.newRoleToolStripMenuItem.Name = "newRoleToolStripMenuItem";
            this.newRoleToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.newRoleToolStripMenuItem.Text = "New Role |";
            this.newRoleToolStripMenuItem.Click += new System.EventHandler(this.newRoleToolStripMenuItem_Click);
            // 
            // refreshRecordsToolStripMenuItem
            // 
            this.refreshRecordsToolStripMenuItem.Name = "refreshRecordsToolStripMenuItem";
            this.refreshRecordsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.refreshRecordsToolStripMenuItem.Text = "Refresh Records";
            this.refreshRecordsToolStripMenuItem.Click += new System.EventHandler(this.refreshRecordsToolStripMenuItem_Click);
            // 
            // RolesDGV
            // 
            this.RolesDGV.AllowUserToAddRows = false;
            this.RolesDGV.AllowUserToDeleteRows = false;
            this.RolesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDGV.Location = new System.Drawing.Point(3, 144);
            this.RolesDGV.Name = "RolesDGV";
            this.RolesDGV.ReadOnly = true;
            this.RolesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RolesDGV.Size = new System.Drawing.Size(854, 379);
            this.RolesDGV.TabIndex = 1;
            this.RolesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RolesDGV_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by Role Title:";
            // 
            // SearchTxb
            // 
            this.SearchTxb.Location = new System.Drawing.Point(129, 76);
            this.SearchTxb.Name = "SearchTxb";
            this.SearchTxb.Size = new System.Drawing.Size(491, 20);
            this.SearchTxb.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SearchBtn.Image = global::UsersManagement.Properties.Resources.search__3_;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchBtn.Location = new System.Drawing.Point(624, 64);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 42);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ViewRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 527);
            this.Controls.Add(this.SearchTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.RolesDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewRolesForm";
            this.Text = "View Roles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRoleToolStripMenuItem;
        private System.Windows.Forms.DataGridView RolesDGV;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTxb;
        private System.Windows.Forms.ToolStripMenuItem refreshRecordsToolStripMenuItem;
    }
}