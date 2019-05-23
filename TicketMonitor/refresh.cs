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
            int seconds;

            programPackage.monitor.apiSession.getRequest(programPackage.monitor.url + "/ra/Tickets.xml?list=group&qualifier=(statustype.listFilterType%3D1)");
            switch (programPackage.monitor.optionSettings.refreshTimeOption)
            {
                case "One Minute":
                    seconds = 60;
                    break;
                case "Five Minutes":
                    seconds = 300;
                    break;
                case "Ten Minutes":
                    seconds = 600;
                    break;
                default:
                    seconds = 300;
                    break;
            }

            programPackage.monitor.setProgressBarMax(seconds);

            for (int i = 0; i < programPackage.monitor.progressBarMax(); i++) //Wait for 5 minutes and then refresh.
            {
                Thread.Sleep(1000);
                progressBarTotal++;
                programPackage.monitor.updateProgress(progressBarTotal);
                if (worker.CancellationPending) //Checks to see if we need to kill the thread.
                {
                    break;
                }
            }

            //Do work here.

            


        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarTotal = 0;
            programPackage.monitor.updateProgress(progressBarTotal);

           
            if (!worker.IsBusy)
            {
                programPackage.monitor.clearText();
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
