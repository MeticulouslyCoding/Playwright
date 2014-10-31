namespace Playwright.src.forms
{
    partial class frmEditor
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
            System.Windows.Forms.ColumnHeader chapterID;
            this.tlbrEditorMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.boxChapter = new System.Windows.Forms.GroupBox();
            this.listChapterView = new System.Windows.Forms.ListView();
            this.chapterIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmChapterView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chapterID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlbrEditorMain.SuspendLayout();
            this.boxChapter.SuspendLayout();
            this.cmChapterView.SuspendLayout();
            this.SuspendLayout();
            // 
            // chapterID
            // 
            chapterID.Text = "ID";
            // 
            // tlbrEditorMain
            // 
            this.tlbrEditorMain.BackColor = System.Drawing.SystemColors.Control;
            this.tlbrEditorMain.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbrEditorMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.tlbrEditorMain.Location = new System.Drawing.Point(0, 0);
            this.tlbrEditorMain.Name = "tlbrEditorMain";
            this.tlbrEditorMain.Size = new System.Drawing.Size(704, 25);
            this.tlbrEditorMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.editProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.toolbarNewProject_Click);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editProjectToolStripMenuItem.Text = "Edit Project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chapterToolStripMenuItem,
            this.sceneToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.quoteToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // chapterToolStripMenuItem
            // 
            this.chapterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.chapterToolStripMenuItem.Name = "chapterToolStripMenuItem";
            this.chapterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chapterToolStripMenuItem.Text = "Chapter";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.toolbarCreateChapter_Click);
            // 
            // sceneToolStripMenuItem
            // 
            this.sceneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1});
            this.sceneToolStripMenuItem.Name = "sceneToolStripMenuItem";
            this.sceneToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sceneToolStripMenuItem.Text = "Scene";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.toolbarCreateScene_Click);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2});
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.characterToolStripMenuItem.Text = "Character";
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem2.Text = "Create";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem3});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // createToolStripMenuItem3
            // 
            this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            this.createToolStripMenuItem3.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem3.Text = "Create";
            // 
            // quoteToolStripMenuItem
            // 
            this.quoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem4});
            this.quoteToolStripMenuItem.Name = "quoteToolStripMenuItem";
            this.quoteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quoteToolStripMenuItem.Text = "Quote";
            // 
            // createToolStripMenuItem4
            // 
            this.createToolStripMenuItem4.Name = "createToolStripMenuItem4";
            this.createToolStripMenuItem4.Size = new System.Drawing.Size(114, 22);
            this.createToolStripMenuItem4.Text = "Create";
            // 
            // boxChapter
            // 
            this.boxChapter.Controls.Add(this.listChapterView);
            this.boxChapter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxChapter.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxChapter.Location = new System.Drawing.Point(12, 28);
            this.boxChapter.Name = "boxChapter";
            this.boxChapter.Size = new System.Drawing.Size(174, 401);
            this.boxChapter.TabIndex = 2;
            this.boxChapter.TabStop = false;
            this.boxChapter.Text = "Chapters";
            // 
            // listChapterView
            // 
            this.listChapterView.BackColor = System.Drawing.SystemColors.Control;
            this.listChapterView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listChapterView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chapterIndex,
            chapterID});
            this.listChapterView.ContextMenuStrip = this.cmChapterView;
            this.listChapterView.FullRowSelect = true;
            this.listChapterView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listChapterView.Location = new System.Drawing.Point(6, 21);
            this.listChapterView.Name = "listChapterView";
            this.listChapterView.Size = new System.Drawing.Size(162, 374);
            this.listChapterView.TabIndex = 3;
            this.listChapterView.UseCompatibleStateImageBehavior = false;
            this.listChapterView.View = System.Windows.Forms.View.Details;
            this.listChapterView.Click += new System.EventHandler(this.chapterView_Click);
            // 
            // chapterIndex
            // 
            this.chapterIndex.Text = "Index";
            // 
            // cmChapterView
            // 
            this.cmChapterView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmChapterView.Name = "cmChapterView";
            this.cmChapterView.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.contextMenuDeleteChapter_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.boxChapter);
            this.Controls.Add(this.tlbrEditorMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.tlbrEditorMain;
            this.MaximizeBox = false;
            this.Name = "frmEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playwright";
            this.Activated += new System.EventHandler(this.frmEditor_Activate);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.tlbrEditorMain.ResumeLayout(false);
            this.tlbrEditorMain.PerformLayout();
            this.boxChapter.ResumeLayout(false);
            this.cmChapterView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem4;
        private System.Windows.Forms.MenuStrip tlbrEditorMain;
        private System.Windows.Forms.GroupBox boxChapter;
        public System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        public System.Windows.Forms.ListView listChapterView;
        private System.Windows.Forms.ContextMenuStrip cmChapterView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chapterIndex;
    }
}

