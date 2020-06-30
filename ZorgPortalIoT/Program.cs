using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorgPortalIoT.Forms;
using ZorgPortalIoT.Model;

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
            //AddPatient("Kazoo", "Kid", 10, "https://i.ytimg.com/vi/B1tL6rFsyAQ/hqdefault.jpg", true);

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

            //Open new form in same location as old form
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = oldForm.Location;

            AppContext.MainForm = newForm;

            //Stop realtimeClock if Form is of type TemplateForm
            if (oldForm is TemplateForm)
            {
                ((TemplateForm)oldForm).StopRefresh();
            }

            oldForm?.Close();
            newForm.Show();
        }

        public static void AddPatient(string voornaam, string achternaam, int leeftijd, string url, bool geslotenKamer)
        {
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                Patient patient = new Patient()
                {
                    Voornaam = voornaam,
                    Achternaam = achternaam,
                    Leeftijd = leeftijd,
                    FotoUrl = url,
                    GeslotenKamer = geslotenKamer
                };

                context.Patient.Add(patient);
                context.SaveChanges();

                foreach (SensorType type in context.SensorType)
                {
                    if (type.TypeId == 5)
                    {
                        continue;
                    }

                    context.Sensor.Add(new Sensor()
                    {
                        Interval = 5000,
                        PatientId = patient.PatientId,
                        SensorType = type.TypeId,
                        Aan = true
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
