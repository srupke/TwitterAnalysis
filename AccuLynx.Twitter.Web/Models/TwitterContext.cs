﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AccuLynx.Twitter.Web.Models
{
    public class TwitterContext : DbContext
    {
        public TwitterContext() : base("name=MyDbConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<TwitterContext>());
        }

        public DbSet<TwitterAnalysis> Analysis { get; set; }
    }
}