namespace ISAManagement
{
    partial class frmSection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSection));
            this.deActivateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associateCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbltag = new System.Windows.Forms.Label();
            this.MemListsV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deActivateProfileToolStripMenuItem
            // 
            this.deActivateProfileToolStripMenuItem.Name = "deActivateProfileToolStripMenuItem";
            this.deActivateProfileToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.deActivateProfileToolStripMenuItem.Text = "De - Activate Profile";
            // 
            // associateCardToolStripMenuItem
            // 
            this.associateCardToolStripMenuItem.Name = "associateCardToolStripMenuItem";
            this.associateCardToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.associateCardToolStripMenuItem.Text = "Associate Card";
            // 
            // ContextStrip
            // 
            this.ContextStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateCardToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.deleteProfileToolStripMenuItem,
            this.deActivateProfileToolStripMenuItem});
            this.ContextStrip.Name = "ContextStrip";
            this.ContextStrip.Size = new System.Drawing.Size(213, 100);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbltag);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MemListsV);
            this.splitContainer1.Size = new System.Drawing.Size(800, 423);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 17;
            // 
            // lbltag
            // 
            this.lbltag.AutoSize = true;
            this.lbltag.Location = new System.Drawing.Point(555, 73);
            this.lbltag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltag.Name = "lbltag";
            this.lbltag.Size = new System.Drawing.Size(0, 17);
            this.lbltag.TabIndex = 39;
            this.lbltag.Visible = false;
            // 
            // MemListsV
            // 
            this.MemListsV.AllowColumnReorder = true;
            this.MemListsV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.MemListsV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemListsV.FullRowSelect = true;
            this.MemListsV.GridLines = true;
            this.MemListsV.HideSelection = false;
            this.MemListsV.Location = new System.Drawing.Point(0, 0);
            this.MemListsV.Margin = new System.Windows.Forms.Padding(4);
            this.MemListsV.MultiSelect = false;
            this.MemListsV.Name = "MemListsV";
            this.MemListsV.Size = new System.Drawing.Size(798, 384);
            this.MemListsV.TabIndex = 0;
            this.MemListsV.TabStop = false;
            this.MemListsV.UseCompatibleStateImageBehavior = false;
            this.MemListsV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Section";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(82, 24);
            this.toolStripButton4.Text = "Refresh";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(114, 24);
            this.saveToolStripButton.Text = "Add Section";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripButton1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time In";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time Out";
            this.columnHeader5.Width = 128;
            // 
            // frmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSection";
            this.Text = "Section and Schedule";
            this.Load += new System.EventHandler(this.frmSection_Load);
            this.ContextStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem deActivateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associateCardToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextStrip;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbltag;
        private System.Windows.Forms.ListView MemListsV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}