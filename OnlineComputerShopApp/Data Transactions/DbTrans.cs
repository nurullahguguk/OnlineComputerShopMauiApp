using OnlineComputerShopApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineComputerShopApp.Data_Transactions
{
    public class DbTrans
    {
        public string DbPath;
        public SQLiteConnection conn;

        public DbTrans(string _dbPath)
        {
            this.DbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.CreateTable<Cpu>();
            conn.CreateTable<Enrollment>();
            conn.CreateTable<Monitors>();
            conn.CreateTable<Ram>();
            conn.CreateTable<Storage>();
            conn.CreateTable<User>();
        }




        //GET
        public List<Cpu> GetAllCpu()
        {
            Init();
            return conn.Table<Cpu>().ToList();
        }
        public List<Enrollment> GetAllEnrollment()
        {
            Init();
            return conn.Table<Enrollment>().ToList();
        }
        public List<Monitors> GetAllMonitors()
        {
            Init();
            return conn.Table<Monitors>().ToList();
        }
        public List<User> GetAllUsers()
        {
            Init();
            return conn.Table<User>().ToList();
        }
        public List<Ram> GetAllRams()
        {
            Init();
            return conn.Table<Ram>().ToList();
        }
        public List<Storage> GetAllStorages()
        {
            Init();
            return conn.Table<Storage>().ToList();
        }

        //ADD
        public void AddCpu(Cpu cpu)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(cpu);
        }
        public void AddRam(Ram ram)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(ram);
        }
        public void AddStorage(Storage storage)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(storage);
        }
        public void AddMonitor(Monitors monitor)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(monitor);
        }
        public void AddUser(User user)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(user);
        }
        public void AddEnrollment(Enrollment enrollment)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Insert(enrollment);
        }
        //DELETE
        public void DeleteCpu(int cpuId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new Cpu { CpuId = cpuId });
        }
        public void DeleteRam(int ramId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new Ram { RamId = ramId });
        }
        public void DeleteStorage(int storageId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new Storage { StorageId = storageId });
        }
        public void DeleteMonitor(int monitorId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new Monitors { MonitorId = monitorId });
        }
        public void DeleteUser(int _userId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new User { UserId = _userId });
        }
        public void DeleteEnrollment(int _enrollId)
        {
            conn = new SQLiteConnection(this.DbPath);
            conn.Delete(new Enrollment { RegId = _enrollId });
        }
    }
}
