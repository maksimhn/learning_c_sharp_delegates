using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{

    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

            DoWork(del1);

            Console.ReadLine();
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.GenerateReports);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work 1 Performed");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work 2 Performed");
        }
    }

    public enum WorkType
    {
        GotToMeetings,
        Golf,
        GenerateReports
    }
}
