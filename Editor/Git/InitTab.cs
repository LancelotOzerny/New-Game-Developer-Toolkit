using UnityEditor;
using UnityEngine;

namespace Lancy.Tools.Git
{
    public class InitTab : WindowTab
    {
        private bool createGitIgnore;
        private Vector2 scrollPosition;
        private string excludeFile =
            "/[Ll]ibrary/" + "\n" +
            "/[Tt]emp/" + "\n" +
            "/[Oo]bj/" + "\n" +
            "/[Bb]uild/" + "\n" +
            "/[Bb]uilds/" + "\n" +
            "/[Ll]ogs/" + "\n" +
            "/[Uu]ser[Ss]ettings/" + "\n" +

            "/[Mm]emoryCaptures/" + "\n" +
            "/[Rr]ecordings/" + "\n" +
            "/[Aa]ssets/Plugins/Editor/JetBrains*" + "\n" +
            ".vs/" + "\n" +
            ".gradle/" + "\n" +

            "ExportedObj/" + "\n" +
            ".consulo/" + "\n" +
            "*.csproj" + "\n" +
            "*.unityproj" + "\n" +
            "*.sln" + "\n" +
            "*.suo" + "\n" +
            "*.tmp" + "\n" +
            "*.user" + "\n" +
            "*.userprefs" + "\n" +
            "*.pidb" + "\n" +
            "*.booproj" + "\n" +
            "*.svd" + "\n" +
            "*.pdb" + "\n" +
            "*.mdb" + "\n" +
            "*.opendb" + "\n" +
            "*.VC.db" + "\n" +

            "*.pidb.meta" + "\n" +
            "*.pdb.meta" + "\n" +
            "*.mdb.meta" + "\n" +

            "sysinfo.txt" + "\n" +

            "*.apk" + "\n" +
            "*.aab" + "\n" +
            "*.unitypackage" + "\n" +
            "*.app" + "\n" +

            "crashlytics-build.properties" + "\n" +
            "/[Aa]ssets/[Aa]ddressable[Aa]ssets[Dd]ata/*/*.bin*" + "\n" +
            "/[Aa]ssets/[Ss]treamingAssets/aa.meta" + "\n" +

            "/[Aa]ssets/[Ss]treamingAssets/aa/*" + "\n";

        public InitTab()
        {
            this.Title = "Repository Init";
        }

        public override void Show()
        {
            SetLabel("Repository Initializing");
            createGitIgnore = GUILayout.Toggle(createGitIgnore, "Create .gitignore File");
            GUILayout.Space(20);
            
            scrollPosition = GUILayout.BeginScrollView(scrollPosition);
            if (createGitIgnore)
            {
                EditorGUILayout.TextArea(excludeFile, GUILayout.MaxHeight(500));
            }
            bool pressed = GUILayout.Button("Initialize", GUILayout.Height(50));

            if (pressed)
            {
                Libs.Git.Instance().Init();
                if (createGitIgnore)
                {
                    Libs.Git.Instance().RewriteIgnore(excludeFile);
                }
            }

            GUILayout.Space(20);
            GUILayout.EndScrollView();
        }
    }
}