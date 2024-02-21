using System.IO;
using UnityEditor;

namespace Lancy.Tools
{
    public class ProjectQuickTools
    {
        [MenuItem("Tools/Quick Tools/Console")]
        public static void OpenProjectCmd() => Console.Run("cmd");

        [MenuItem("Tools/Quick Tools/Open Builds Folder")]
        public static void OpenBuildFolder()
        {
            string path = Directory.GetCurrentDirectory() + "/Builds";
            bool exists = Directory.Exists(path);

            if (exists == false)
            {
                Directory.CreateDirectory(path);
            }

            Console.Run($"start {path}");
        }
    }
}