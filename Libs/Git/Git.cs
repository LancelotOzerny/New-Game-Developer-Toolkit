using System.IO;

namespace Lancy.Libs.Git
{
    public class Git
    {
        private static Git instance = null;

        public Git()
        {
            if (Exist() == false)
            {
                return;
            }
        }

        public static Git Instance()
        {
            if (instance == null)
            {
                instance = new Git();
            }

            return instance;
        }

        public void Init()
        {
            Tools.Console.Run("git init", 250);
        }

        public bool Exist()
        {
            string dir = Directory.GetCurrentDirectory() + "\\.git";
            if (Directory.Exists(dir))
            {
                return true;
            }

            return false;
        }
    }
}