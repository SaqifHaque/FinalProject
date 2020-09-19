using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class FinalDataContext : DbContext
    {
        public FinalDataContext()
        {
            Database.SetInitializer<FinalDataContext>(new DropCreateDatabaseIfModelChanges<FinalDataContext>());
        }
        virtual public DbSet<User> Users { get; set; }
    }

}