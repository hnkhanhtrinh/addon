using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
   public class MyDbContext : IDisposable
    {
        public ILiteCollection<MachineState> MachineCollection { get; set; }
        private ILiteDatabase _db;
        public MyDbContext()
        {
            _db = new LiteDatabase(@"AddOn.db");
            MachineCollection = _db.GetCollection<MachineState>("Machines");
            MachineCollection.EnsureIndex(x => x.Id, true);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
