﻿namespace ISAManagement
{
    partial class sHistoryfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sHistoryfrm));
            this.ddLetter = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemListsV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.lbltag = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.ContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.associateCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deActivateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddLetter
            // 
            this.ddLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLetter.FormattingEnabled = true;
            this.ddLetter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "All"});
            this.ddLetter.Location = new System.Drawing.Point(215, 82);
            this.ddLetter.Margin = new System.Windows.Forms.Padding(4);
            this.ddLetter.Name = "ddLetter";
            this.ddLetter.Size = new System.Drawing.Size(65, 24);
            this.ddLetter.TabIndex = 47;
            this.ddLetter.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Section";
            this.columnHeader8.Width = 111;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Student ID";
            this.columnHeader9.Width = 133;
            // 
            // MemListsV
            // 
            this.MemListsV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader10});
            this.MemListsV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemListsV.FullRowSelect = true;
            this.MemListsV.GridLines = true;
            this.MemListsV.HideSelection = false;
            this.MemListsV.Location = new System.Drawing.Point(0, 0);
            this.MemListsV.Margin = new System.Windows.Forms.Padding(4);
            this.MemListsV.MultiSelect = false;
            this.MemListsV.Name = "MemListsV";
            this.MemListsV.Size = new System.Drawing.Size(1192, 411);
            this.MemListsV.TabIndex = 1;
            this.MemListsV.TabStop = false;
            this.MemListsV.UseCompatibleStateImageBehavior = false;
            this.MemListsV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Record ID";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grade";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "First Name";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Middle Name";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Card No";
            this.columnHeader7.Width = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Search By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search";
            // 
            // cmbSBy
            // 
            this.cmbSBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSBy.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSBy.FormattingEnabled = true;
            this.cmbSBy.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Member ID"});
            this.cmbSBy.Location = new System.Drawing.Point(550, 34);
            this.cmbSBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSBy.Name = "cmbSBy";
            this.cmbSBy.Size = new System.Drawing.Size(264, 27);
            this.cmbSBy.TabIndex = 42;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(155, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 27);
            this.txtSearch.TabIndex = 41;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.Location = new System.Drawing.Point(823, 33);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(52, 31);
            this.searchbtn.TabIndex = 40;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // lbltag
            // 
            this.lbltag.AutoSize = true;
            this.lbltag.Location = new System.Drawing.Point(550, 99);
            this.lbltag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltag.Name = "lbltag";
            this.lbltag.Size = new System.Drawing.Size(0, 17);
            this.lbltag.TabIndex = 48;
            this.lbltag.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbltag);
            this.splitContainer1.Panel1.Controls.Add(this.ddLetter);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSBy);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.searchbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MemListsV);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 627);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "View Last name By";
            this.label3.Visible = false;
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
            // associateCardToolStripMenuItem
            // 
            this.associateCardToolStripMenuItem.Name = "associateCardToolStripMenuItem";
            this.associateCardToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.associateCardToolStripMenuItem.Text = "Associate Card";
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
            // deActivateProfileToolStripMenuItem
            // 
            this.deActivateProfileToolStripMenuItem.Name = "deActivateProfileToolStripMenuItem";
            this.deActivateProfileToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.deActivateProfileToolStripMenuItem.Text = "De - Activate Profile";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Status";
            // 
            // sHistoryfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 627);
            this.Controls.Add(this.splitContainer1);
            this.Name = "sHistoryfrm";
            this.Text = "Student Time History";
            this.Load += new System.EventHandler(this.sHistoryfrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddLetter;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView MemListsV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label lbltag;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ContextStrip;
        private System.Windows.Forms.ToolStripMenuItem associateCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deActivateProfileToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}