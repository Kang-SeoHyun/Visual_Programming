namespace Controller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // ���� ������Ʈ ����
            //Application.Run(new Intro());
            //Application.Run(new Login());
            //Application.Run(new GroupBox());
            Application.Run(new Address());
        }
    }
}