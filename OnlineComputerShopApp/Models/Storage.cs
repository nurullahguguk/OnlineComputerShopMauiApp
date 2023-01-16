using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Models
{
    public class Storage
    {
        [PrimaryKey, AutoIncrement]
        public int StorageId { get; set; }
        public string StorageType { get; set; }
        public string StorageSize { get; set; }
    }
}
