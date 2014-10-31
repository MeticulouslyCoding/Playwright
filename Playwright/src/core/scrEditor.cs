using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Playwright.src.forms;

namespace Playwright.src.core
{
    public enum SelectionType
    {
        Project,
        Chapter,
        Scene,
        Character,
        Location,
        Quote
    }

    public enum DataType
    {
        ProjectName,
        ProjectAuthor,
        ProjectSeries,
        ChapterName,
    }

    class scrEditor
    {
        public static class EditorReferences
        {
            public static ListView chapterView;
        }

        public class EditorFunctions
        {
            public void AddToChapterView(string chaptername, int index)
            {
                ListViewItem newItem = new ListViewItem(index.ToString());
                newItem.SubItems.Add(chaptername);

                EditorReferences.chapterView.Items.Add(newItem);
            }

            public void DeleteFromChapterView()
            {
                for (int i = EditorReferences.chapterView.Items.Count - 1; i >= 0; i--)
                {
                    if (EditorReferences.chapterView.Items[i].Selected)
                    {
                        omniPlaywright.Common.Chapters.Remove(i);
                        EditorReferences.chapterView.Items[i].Remove();
                        MessageBox.Show("Removed: " + i.ToString());
                        MessageBox.Show(omniPlaywright.Common.Chapters.Count.ToString());
                    }
                }
               
                int rc = 0;
                foreach(ListViewItem item in scrEditor.EditorReferences.chapterView.Items)
                {
                    item.Text = rc.ToString();
                    rc++;
                }

                int ys = 0;
                foreach(item itm in omniPlaywright.Common.Chapters.Values)
                {
                    itm.Index = ys;
                    ys++;
                }
            }
        }
    }
}