using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicketMonitor
{
    class refresh
    {

        internal static BackgroundWorker worker = new BackgroundWorker();
        private int progressBarTotal = 0;
        internal refresh()
        {
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

        }

        internal void start()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
           
        private void worker_DoWork(object sender, DoWorkEventArgs e) //This worker loads in the tickets.
        {
            int miliseconds;

            switch (programPackage.monitor.optionSettings.refreshTimeOption)
            {
                case "One Minute":
                    miliseconds = 60000;
                    break;
                case "Five Minutes":
                    miliseconds = 300000;
                    break;
                case "Ten Minutes":
                    miliseconds = 600000;
                    break;
                default:
                    miliseconds = 300000;
                    break;
            }

            programPackage.monitor.setProgressBarMax(miliseconds);

            for (int i = 0; i < programPackage.monitor.progressBarMax(); i++) //Wait for 5 minutes and then refresh.
            {
                Thread.Sleep(1);
                progressBarTotal++;
                programPackage.monitor.updateProgress(progressBarTotal);
                if (worker.CancellationPending) //Checks to see if we need to kill the thread.
                {
                    break;
                }
            }

            //Do work here.
            Console.Write(progressBarTotal);

            
            
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarTotal = 0;
            programPackage.monitor.updateProgress(progressBarTotal);
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        internal void stop()
        {
            worker.CancelAsync();
            GC.Collect(); //manual garbage collection!
        }
    }
}
