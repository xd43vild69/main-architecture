using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DTO;

namespace Migrations.Context
{
    public class MigrationContext : DbContext
    {
        public MigrationContext() : base("StringConn")
        {

        }
        public DbSet<Animal> Animals { get; set; }
        //public DbSet<Schedule> Schedules { get; set; }
        //public DbSet<TypeSchedule> TypeSchedules { get; set; }
    }
}
