#region Usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Playwright.src.forms;
#endregion

namespace Playwright.src.core
{
    /// <summary>
    /// 
    /// </summary>
    class scrAssigner
    {
        public SelectionType Type;
        private Dictionary<DataType, string> Input = new Dictionary<DataType, string>();
        private scrIndex Index = new scrIndex();
        private scrEditor.EditorFunctions Ef = new scrEditor.EditorFunctions();

        public void AssignProperty(DataType type, string input)
        {
            Input.Add(type, input);
        }

        public void Create()
        {
            switch(Type)
            {
                case SelectionType.Project:
                    item proj = new item();
                    string pname = "", auth = "", ser = "";
                    
                    pname = Input[DataType.ProjectName];
                    auth = Input[DataType.ProjectAuthor];
                    ser = Input[DataType.ProjectSeries];
                   
                    proj.Name = pname;
                    proj.Author = auth;
                    proj.Series = ser;
                    Store(proj);
                    break;

                case SelectionType.Chapter:
                    item chap = new item();
                    string cname = "";
                    
                    cname = Input[DataType.ChapterName];
                   
                    chap.Name = cname;
                    chap.Index = Index.GetCurrentIndex();
                    MessageBox.Show("Added Chapter Index: " + chap.Index);
                    Store(chap);
                    break;
            }
        }

        private void Store(item item)
        {
            switch(Type)
            {
                case SelectionType.Project:
                    omniPlaywright.Common.project = new item();
                    omniPlaywright.Common.project.Name = item.Name;
                    omniPlaywright.Common.project.Author = item.Author;
                    omniPlaywright.Common.project.Series = item.Series;
                    break;

                case SelectionType.Chapter:
                    try
                    {
                        omniPlaywright.Common.Chapters.Add(item.Index, item);
                        Ef.AddToChapterView(item.Name, item.Index);
                    }
                    catch(ArgumentException)
                    {
                        MessageBox.Show("An item of that name already exists!");
                    }
                    break;
            }
        }
    }
}