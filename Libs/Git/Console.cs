namespace Lancy.Tools
{
    public class Console
    {
        /// <summary>
        /// �����, ������� ��������� ��������� �����-���� ������� � ��������� ������ Cmd.exe
        /// </summary>
        /// <param name="command">�������, ������� ��������� ���������</param>
        /// <param name="sleep">�������� ����� �������</param>
        public static void Run(string command, int sleep = 0)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C" + command);
            System.Threading.Thread.Sleep(sleep);
        }
    }
}