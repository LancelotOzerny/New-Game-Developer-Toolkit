using UnityEngine;

namespace Lancy.Tools.Git
{
    public class CommitTab : WindowTab
    {
        private string commitMessage = string.Empty;

        public CommitTab()
        {
            this.Title = "Commit Tab";
        }

        public override void Show()
        {
            GUILayout.Space(20);
            SetLabel("Commit Area");

            GUILayout.Space(20);
            bool indexAll = GUILayout.Button("Indexing All", GUILayout.Height(50));

            GUILayout.Space(20);
            SetLabel("Commit Message");
            commitMessage = GUILayout.TextArea(commitMessage, GUILayout.MinHeight(100));

            GUILayout.Space(20);
            bool startCommit = GUILayout.Button("Commit", GUILayout.Height(50));

            if (indexAll)
            {
                Libs.Git.Instance().IndexAll();
            }

            if (startCommit)
            {
                Libs.Git.Instance().Commit(commitMessage);
                commitMessage = string.Empty;
            }
        }
    }
}