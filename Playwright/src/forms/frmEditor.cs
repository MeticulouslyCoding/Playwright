#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Playwright.src.core;
#endregion

namespace Playwright.src.forms
{
    /// <summary>
    /// Editor's 'Form' class. Provides a frontend of the Editor functionality.
    /// </summary>
    public partial class frmEditor : Form
    {
        #region Variables
        //Reference to the "EditorFunctions" class.
        scrEditor.EditorFunctions editorFunctions;
        #endregion

        #region Start
        /// <summary>
        /// Initialize method.
        /// </summary>
        public frmEditor()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        /// <summary>
        /// Loading method. Loaded only once upon initial activation. 
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="l">Load Event</param>
        private void frmEditor_Load(object sender, EventArgs l)
        {
            editorFunctions = new scrEditor.EditorFunctions();
            scrEditor.EditorReferences.chapterView = listChapterView;
        }
        #endregion

        #region Activate
        /// <summary>
        /// Activation method. Occurs each time the form comes back into focus.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="a">Activate Event</param>
        private void frmEditor_Activate(object sender, EventArgs a)
        {
            if(omniPlaywright.Common.project != null)
            {
                this.Text = "Playwright: " + omniPlaywright.Common.project.Name + " by " + omniPlaywright.Common.project.Author + " of " + omniPlaywright.Common.project.Series;
                itemToolStripMenuItem.Visible = true;
            }
            else
            {
                itemToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region Toolbar Click Events
        /// <summary>
        /// Toolbar click, to create a new 'Project'.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="c">Click Event</param>
        private void toolbarNewProject_Click(object sender, EventArgs c)
        {
            frmAssigner newProject = new frmAssigner();
            newProject.Type = SelectionType.Project;
            newProject.ShowDialog();
        }

        /// <summary>
        /// Toolbar click, to create a new 'Chapter'.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="c">Click Event</param>
        private void toolbarCreateChapter_Click(object sender, EventArgs c)
        {
            frmAssigner newChapter = new frmAssigner();
            newChapter.Type = SelectionType.Chapter;
            newChapter.ShowDialog();
        }

        /// <summary>
        /// Toolbar click, to create a new 'Scene'.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="c">Click Event</param>
        private void toolbarCreateScene_Click(object sender, EventArgs c)
        {
            frmAssigner newScene = new frmAssigner();
            newScene.Type = SelectionType.Scene;
            newScene.ShowDialog();
        }
        #endregion

        #region Context Menu Events
        /// <summary>
        /// Context menu activation - for 'chapterView'.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="m">Click Event</param>
        private void contextMenuDeleteChapter_Click(object sender, EventArgs m)
        {
            editorFunctions.DeleteFromChapterView();
        }
        #endregion

        #region chapterView Events
        /// <summary>
        /// chapterView click, to identify/select the selected item in the list. 
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="c">Click Event</param>
        private void chapterView_Click(object sender, EventArgs c)
        {
            //MessageBox.Show(listChapterView.SelectedItems[0].SubItems[1].Text);
        }
        #endregion
    }
}