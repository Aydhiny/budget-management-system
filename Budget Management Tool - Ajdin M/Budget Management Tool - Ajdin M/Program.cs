using Budget_Management_Tool___Ajdin_M.FrontForms;

namespace Budget_Management_Tool___Ajdin_M
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
            Application.Run(new userLogin());
        }
    }
}