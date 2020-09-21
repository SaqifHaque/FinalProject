﻿using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected FinalDataContext context;
        public Repository()
        {
            this.context = new FinalDataContext();
        }

        public T GetByName(string uname)
        {
            return context.Set<T>().Find(uname);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

    }
}