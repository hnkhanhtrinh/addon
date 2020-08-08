
using Quartz;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1.Utils
{
    public class ExportExcelJob : IJob
    {
        //public void Execute(IJobExecutionContext context)
        //{
        //    Console.WriteLine(DateTime.Now + "----exportexcel");
        //    ExportData();
        //    //export excel
        //}

        Task IJob.Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now + "----exportexcel");
            ExportData();
            return Task.CompletedTask;
            //throw new System.NotImplementedException();
        }

        private void ExportData()
        {
            using (var db = new MyDbContext())
            {
                // lay data downtime
                var listDowntime = db.MachineCollection.Find(x => x.FlagDown).GroupBy(x => x.Id).Select(g => new
                {
                    g.FirstOrDefault().Date,
                    Id = g.Key,
                    g.FirstOrDefault().Address,
                    Downtime = g.Sum(x => x.Downtime),
                    Counter = g.ToList().Count
                }).ToList();
                if (listDowntime.Count > 0)
                {
                    string csv = string.Empty;
                    // export data downtime
                    //        DataTable dt = new DataTable();
                    //        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Date", typeof(string)),
                    //new DataColumn("Machine", typeof(string)),
                    //new DataColumn("Downtime",typeof(int)),
                    //new DataColumn("Counter",typeof(int)),
                    //new DataColumn("Address PLC",typeof(string))});
                    csv += "Date,Machine,Downtime,Counter,Address PCL\r\n";
                    foreach (var mc in listDowntime)
                    {
                        //dt.Rows.Add(mc.Date.ToString("DD/mm/yyy") , mc.Id, mc.Downtime, mc.Downtime, mc.Address);
                        csv += mc.Date + "," + mc.Id + "," + mc.Downtime + "," + mc.Counter + "," + mc.Address +"\r\n";

                    }

                    string folderName = DateTime.Now.ToString("DD-mm-yyyy");
                    if (!Directory.Exists(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                    }

                    File.WriteAllText(folderName+"/DataGridViewExport.csv", csv);
                }


            }
        }
    }
}
