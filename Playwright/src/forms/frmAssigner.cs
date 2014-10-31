#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Playwright.src.core;
#endregion

namespace Playwright.src.forms
{
    /// <summary>
    /// Assigner class provides ways of creating different data types.
    /// </summary>
    public partial class frmAssigner : Form
    {
        #region Variables
        //Type of data to be created (based on what the user selected).
        public SelectionType Type;
        #endregion

        #region Start
        /// <summary>
        /// Initialize method.
        /// </summary>
        public frmAssigner()
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
        public void frmAssigner_Load(object sender, EventArgs l)
        {
            #region Altering Controls (Depending on Selection)
            //Change control elements depending on what is being created.
            switch(Type)
            {
                case SelectionType.Project:
                    this.Text = "Playwright: New Project"; //Change window title.
                    lbName.Text = "Name: ";                //Change label text.
                    lbAuthor.Text = "Author: ";            
                    lbSeries.Text = "Series: ";            
                    tbNameInput.Text = null;               //Enable textbox for use.
                    cbPartOf.Enabled = false;
                    break;

                case SelectionType.Chapter:
                    this.Text = "Playwright: New Chapter";
                    lbName.Text = "Name: ";
                    lbAuthor.Text = "N/A";
                    lbSeries.Text = "N/A";
                    tbAuthorInput.Enabled = false;
                    tbSeriesInput.Enabled = false;
                    cbPartOf.Enabled = false;
                    break;

                case SelectionType.Scene:
                    break;
            }
            #endregion
        }
        #endregion

        #region Button Click Events
        /// <summary>
        /// Confirm click event method. For when the user want's to confirm their input.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="c">Click Event</param>
        public void btnConfirm_Click(object sender, EventArgs c)
        {
            #region Altering Event (Depending on Selection)
            //Change creation method depending on type of data being created.
            switch(Type)
            {
                case SelectionType.Project:
                    scrAssigner assignProject = new scrAssigner();
                    assignProject.AssignProperty(DataType.ProjectName, tbNameInput.Text);
                    assignProject.AssignProperty(DataType.ProjectAuthor, tbAuthorInput.Text);
                    assignProject.AssignProperty(DataType.ProjectSeries, tbSeriesInput.Text);
                    assignProject.Type = SelectionType.Project;
                    assignProject.Create();
                    break;

                case SelectionType.Chapter:
                    scrAssigner assignChapter = new scrAssigner();
                    assignChapter.AssignProperty(DataType.ChapterName, tbNameInput.Text);
                    assignChapter.Type = SelectionType.Chapter;
                    assignChapter.Create();
                    break;

                case SelectionType.Scene:
                    break;
            }
            #endregion
            this.Close(); //Destroy window.
        }
        #endregion
    }
}