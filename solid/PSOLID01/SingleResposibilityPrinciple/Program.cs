using SingleResposibilityPrinciple.Entities;
using System;

namespace SingleResposibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkRepot();
            report.AddEntry(new WorkerReportEntry() { ProjectCode = "123Ds", ProjectName = "Proyecto1", SpentHourts = 5 });
            report.AddEntry(new WorkerReportEntry() { ProjectCode = "987FC", ProjectName = "Proyecto2", SpentHourts = 3 });

            var sheduler = new Sheduler();
            sheduler.AddEntry(new SchedulerTask {TaskId=1,Content="Do shometing now.",ExcuteOn=DateTime.Now.AddDays(5) });
            sheduler.AddEntry(new SchedulerTask { TaskId = 1, Content = "Do shometing now.", ExcuteOn = DateTime.Now.AddDays(2) });
            Console.WriteLine(report.ToString());
            Console.WriteLine(sheduler.ToString());
            
            var saver = new FileServer();
            saver.SaveToFile(@"D:\Archivo\", "WorkReport.txt",report);
            saver.SaveToFile(@"Sheulderts", "sheduler.txt",sheduler);
            Console.ReadKey();

        }
    }
}
