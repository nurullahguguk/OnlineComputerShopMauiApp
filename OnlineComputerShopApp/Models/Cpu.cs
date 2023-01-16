using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Models
{
    public class Cpu
    {
        [PrimaryKey, AutoIncrement]

        public int CpuId { get; set; }
        public string CpuName { get; set; }
        public decimal CpuPrice { get; set; }
    }
}
