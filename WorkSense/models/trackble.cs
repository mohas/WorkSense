using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.models
{
    class trackable
    {
        public int id { get; set; }
        public string name { get; set; }

        public string fileName { get; set; }
        public string titleRegex { get; set; }
        public string categoriesCsv { get; set; }
        [NotMapped]
        public string[] categories { get { return string.IsNullOrWhiteSpace(categoriesCsv) ? new string[0] : categoriesCsv.Split(','); } }
    }
}
