using System.IO;

namespace Lancy.Libs
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

        public void IndexAll()
        {
            Tools.Console.Run("git add .", 750);
        }

        public void Commit(string message)
        {
            Tools.Console.Run($"git commit -m \"{message}\"", 250);
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

        public void RewriteIgnore(string exclude)
        {
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\.gitignore"))
            {
                sw.WriteLine(exclude);
            }
        }
    }
}