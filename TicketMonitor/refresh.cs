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

        }

        internal void start()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }
           
        private void worker_DoWork(object sender, DoWorkEventArgs e) //This worker loads in the tickets.
        {   for(int i = 0; i < programPackage.monitor.progressBarMax(); i++) //Wait for 5 minutes and then refresh.
            {
                Thread.Sleep(1);
                progressBarTotal++;
                programPackage.monitor.updateProgress(progressBarTotal);
            }

            //Do work here.
            Console.Write(progressBarTotal);

            
            
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarTotal = 0;
            programPackage.monitor.updateProgress(progressBarTotal);
            worker.RunWorkerAsync();
        }
    }
}
