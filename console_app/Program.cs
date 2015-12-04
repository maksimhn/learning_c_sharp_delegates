using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{

    public delegate int BizRulesDelegate(int x, int y);

    
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ProcessData();
            BizRulesDelegate addDel = (x,y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            data.Process(2, 3, addDel);

            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(4, 5, myAction);

            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            //del1(5, WorkType.Golf);

            //Console.ReadLine();

            var worker = new Worker();

            worker.WorkPerformed += (s,e) => Console.WriteLine(e.Hours + " " + e.WorkType);
            // worker.WorkCompleted += worker_WorkCompleted;
            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker is done");
            worker.DoWork(8, WorkType.GenerateReports);
        }

        //static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine(e.Hours + " " + e.WorkType);
        //}

        //static void worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done");
        //}

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
