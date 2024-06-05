using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NptLesson06CF.Models
{
    public class NptBookStore
    {
        public object NptCategories { get; internal set; }
        public object NPTCategories { get; internal set; }

        public class NptBookstore:DbContext
        {
            public NptBookstore():base() { }
            //Khai bao cac thuoc tinh tuong ung voi cac bang trong csdl
            public DbSet<NptCategory> NptCategories { get;  set; }
            public DbSet<NptBook> NptBooks { get; set; }
        }
    }
}