using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.models
{
    class track
    {
        [Key, Autoincrement]
        public long id { get; set; }
        public string context { get; set; }
        public trackable trackble { get; set; }
        public DateTime startTime{ get; set; }
        public DateTime? endTime { get; set; }
    }
}
