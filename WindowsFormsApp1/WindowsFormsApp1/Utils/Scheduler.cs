using Quartz;
using Quartz.Impl;
using System;

namespace WindowsFormsApp1.Utils
{
    public class Scheduler
    {
        public void Start()

        {

            IScheduler scheduler = (Quartz.IScheduler) StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<ExportExcelJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("IDGJob", "IDG")
               .WithCronSchedule("59 23 * * *")
               .StartNow()
               .WithPriority(1)
               .Build();
            scheduler.ScheduleJob(job, trigger);

        }

    }
}
