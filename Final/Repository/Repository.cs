using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Repository
{
    public class Repository : IRepository
    {
        protected FinalDataContext context;
        public Repository()
        {
            this.context = new FinalDataContext();
        }

        public User GetByName(string uname)
        {
            return context.Set<User>().Find(uname);
        }

    }
}