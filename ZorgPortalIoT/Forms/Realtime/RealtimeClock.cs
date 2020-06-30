using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZorgPortalIoT.Model;
using ZorgPortalIoT.Forms.Realtime;

namespace ZorgPortalIoT.Forms
{
    public partial class TemplateForm
    {
        public DateTime startTime = DateTime.Now;

        private CancellationTokenSource StopSource { get; set; }

        /// <summary>
        /// Running property.
        /// </summary>
        /// <value>
        /// Tracks if the clock is running.
        /// </value>
        public bool Running { get; private set; }

        /// <summary>
        /// Interval in milliseconds.
        /// </summary>
        /// <value>
        /// The amount of milliseconds the clock waits before resfreshing data.
        /// </value>
        private readonly int interval = 10000;

        /// <summary>
        /// Main async loop that refreshes data each interval.
        /// </summary>
        private async void RealtimeClock()
        {
            while (!StopSource.IsCancellationRequested)
            {
                //Run refresh function
                await Task.Run(RefreshData);
                await Task.Run(AlarmAlert);

                Console.WriteLine($"Refresh activated on object: {this.ToString()}");

                //Cancel delay to stop task on request
                try
                {
                    //Delay for interval milliseconds
                    await Task.Delay(interval, StopSource.Token);
                }
                catch (TaskCanceledException)
                {
                    break;
                }

            }
        }

        /// <summary>
        /// Starts the clock.
        /// </summary>
        public void StartRefresh()
        {
            //Ensure previous instances are stopped before running a new one
            if (StopSource != null)
            {
                StopRefresh();
            }

            //Set new CancellationSource to stop process later and run a new data generator
            StopSource = new CancellationTokenSource();
            Task.Run(RealtimeClock, StopSource.Token);

            Running = true;
        }

        /// <summary>
        /// Stops the clock.
        /// </summary>
        public void StopRefresh()
        {
            try
            {
                StopSource.Cancel();
                StopSource.Dispose();
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("An attempt was made to stop a clock that was not running.");
            }

            Running = false;
        }

        /// <summary>
        /// Function that gets called every interval, it reshreshes the data of the form.
        /// </summary>
        virtual public void RefreshData() 
        {
            //Refresh code hier
        }

        /// <summary>
        /// Function that notifies of new alarms
        /// </summary>
        virtual public void AlarmAlert()
        {
            
            using (b2d4ziekenhuisContext context = new b2d4ziekenhuisContext())
            {
                List<SensorMeting> alarmen = context.SensorMeting.Where(meting => meting.Alarm == true && meting.MetingTimestamp >= startTime).ToList();
                
                foreach (SensorMeting alarm in alarmen) 
                {
                    Sensor sensor = context.Sensor.Find(alarm.SensorId);
                    Patient patient = context.Patient.Find(sensor.PatientId);
                    string sensornaam = string.IsNullOrEmpty(sensor.Naam) ? context.SensorType.Find(sensor.SensorType).Naam : sensor.Naam;
                    string patientNaam = $"{patient.Voornaam} {patient.Achternaam}";
                    AlertPopup($"{sensornaam} {patientNaam}");
                }
            }

            this.startTime = DateTime.Now;
        }

        private void AlertPopup (string message)
        {
            this.Invoke((Action)delegate {
                AlertForm popup = new AlertForm();
                popup.showAlert(message);
            });
            
            Console.WriteLine("Attempting popup");
        }
    }
}
