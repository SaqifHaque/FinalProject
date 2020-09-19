using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Repository
{
    interface IRepository
    {
        User GetByName(string uname);
    }
}