using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Models
{
    public class Ram
    {
        [PrimaryKey, AutoIncrement]
        public int RamId { get; set; }
        public string RamName { get; set; }
        public string RamSize { get; set; }
    }
}
