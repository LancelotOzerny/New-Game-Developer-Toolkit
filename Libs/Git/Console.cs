namespace Lancy.Tools
{
    public class Console
    {
        /// <summary>
        /// Метод, который позволяет запустить какую-либо команду в командной строке Cmd.exe
        /// </summary>
        /// <param name="command">Команда, которую требуется выполнить</param>
        /// <param name="sleep">Задержка после команды</param>
        public static void Run(string command, int sleep = 0)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C" + command);
            System.Threading.Thread.Sleep(sleep);
        }
    }
}