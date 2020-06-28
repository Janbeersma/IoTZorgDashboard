using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorgPortalIoT.Forms;

namespace ZorgPortalIoT
{
    static class Program
    {
        public static ApplicationContext AppContext { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.AppContext = new ApplicationContext(new HoofdpaginaForm());
            Application.Run(AppContext);
        }

        /// <summary>
        /// Helper method to switch forms
        /// </summary>
        /// <param name="newForm">The new form to open</param>
        public static void SwitchForm(Form newForm)
        {
            var oldForm = AppContext.MainForm;
            AppContext.MainForm = newForm;

            //Stop realtimeClock if Form is of type TemplateForm
            if (oldForm is TemplateForm)
            {
                ((TemplateForm)oldForm).StopRefresh();
            }

            oldForm?.Close();
            newForm.Show();
        }
    }
}
