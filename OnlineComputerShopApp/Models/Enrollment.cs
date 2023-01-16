using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Models
{
    public class Enrollment
    {
        

        //CPU
        public int CpuId { get; set; }
        public string CpuName { get; set; }
        
        //

        public int StorageId { get; set; }
        public string StorageBrand { get; set; }


        //
        [PrimaryKey, AutoIncrement]
        public int RegId { get; set; }
        public DateTime Date { get; set; }
        public string Hostname { get; set; }
        


    }
}
