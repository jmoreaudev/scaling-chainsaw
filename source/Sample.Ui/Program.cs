﻿using Sample.Ui.Common;
using System;
using System.Windows.Forms;

namespace Sample.Ui
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Common.ApplicationContainer());
        }
    }
}
