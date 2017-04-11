using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.Entity;

namespace Tree.Classes
{
    class DBContext: DbContext
    {
        public DBContext() : base("MyContext") { }
        public DbSet<Users> UsersDB { get; set; }

    }
}
