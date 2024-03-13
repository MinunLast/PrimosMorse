using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace FormPrimosMorse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Luego puedes utilizar settingValue según sea necesario

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}
