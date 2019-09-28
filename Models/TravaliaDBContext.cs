using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{
    public class TravaliaDBContext : DbContext
    {

        public DbSet<StateTable> StateTables { get; set; }
        public DbSet<DistrictTable> DistrictTables { get; set; }

    }
    public class StateTable
    {
        public int Id { get; set; }
        public string StateName { get; set; }
    }
    public class DistrictTable
    {
        public int Id { get; set; }
        public int Sid { get; set; }
        public string DistrictName { get; set; }
    }

}