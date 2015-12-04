using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{

    
    class Program
    {
        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            //del1(5, WorkType.Golf);

            //Console.ReadLine();

            var worker = new Worker();

            worker.WorkPerformed += worker_WorkPerformed;
            worker.WorkCompleted += worker_WorkCompleted;
            worker.WorkCompleted -= worker_WorkCompleted;
            worker.DoWork(8, WorkType.GenerateReports);
        }

        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GenerateReports);
        //}

        //static void WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work 1 Performed");
        //}

        //static void WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work 2 Performed");
        //}

        //static void WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work 3 Performed");
        //}
    }

    public enum WorkType
    {
        GotToMeetings,
        Golf,
        GenerateReports
    }
}
