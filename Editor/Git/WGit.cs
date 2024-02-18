using UnityEditor;

namespace Lancy.Git
{
    public class WGit : EditorWindow
    {
        [MenuItem("Tools/Git")]
        public static new void Show()
        {
            EditorWindow.GetWindow(typeof(WGit));
        }
    }
}