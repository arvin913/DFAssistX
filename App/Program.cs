﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace App
{
    internal static class Program
    {
        private const string AppName = "DFAssistX";

        private static Mutex _mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Mutex.OpenExisting(AppName);
            }
            catch
            {
                _mutex = new Mutex(true, AppName);
                AppStart();
            }
        }

        private static void AppStart()
        {
#if !DEBUG
            Sentry.Initialise();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new MainForm();
            Application.Run(form);
        }
    }
}
