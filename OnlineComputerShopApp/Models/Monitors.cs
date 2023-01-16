using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Models
{
    public class Monitors
    {
        [PrimaryKey, AutoIncrement]
        public int MonitorId { get; set; }
        public string MonitorBrand { get; set; }
        public string MonitorInch { get; set; }


    }
}
