using UnityEditor;
using UnityEngine;

namespace Lancy.Tools
{
    public class ToolLinks
    {
        private static void SafeUrl(string name) => Application.OpenURL($"https://{name}");
        private static void UnSafeUrl(string name) => Application.OpenURL($"http://{name}");


        [MenuItem("Tools/Links/Unity Asset Store")]
        public static void OpenUnityStore() => SafeUrl("assetstore.unity.com");

        [MenuItem("Tools/Links/Colormind")]
        public static void OpenColormind() => UnSafeUrl("colormind.io");

        [MenuItem("Tools/Links/Iconfinder")]
        public static void OpenIconfinder() => SafeUrl("www.iconfinder.com");

        [MenuItem("Tools/Links/Google Fonts")]
        public static void OpenGoogleFonts() => SafeUrl("fonts.google.com");

        [MenuItem("Tools/Links/Lancy-Studio")]
        public static void OpenLancyStudio() => SafeUrl("lancy-studio.ru");

        [MenuItem("Tools/Links/GitHub")]
        public static void OpenGitHub() => SafeUrl("github.com");
    }
}
