using Lancy.Tools;
using Lancy.Tools.Git;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lancy.Git
{
    public class WGit : EditorWindow
    {
        [MenuItem("Tools/Git")]
        public static new void Show()
        {
            EditorWindow.GetWindow(typeof(WGit));
        }

        private List<WindowTab> tabs = new List<WindowTab>();
        private List<string> tabTitles = new List<string>();
        private int CurrentTabIndex { get; set; }
        private InitTab init = new InitTab();

        public WGit()
        {
            // tabs.Add(new WindowTabChildren());

            foreach (WindowTab tab in tabs)
            {
                tabTitles.Add(tab.Title);
            }
        }

        private void OnGUI()
        {
            if (Libs.Git.Instance().Exist() == false)
            {
                GUILayout.Toolbar(1, new string[] { init.Title });
                init.Show();

                return;
            }

            if (tabs.Count <= 0)
            {
                return;
            }

            CurrentTabIndex = GUILayout.Toolbar(CurrentTabIndex, tabTitles.ToArray());
            tabs[CurrentTabIndex].Show();
        }
    }
}