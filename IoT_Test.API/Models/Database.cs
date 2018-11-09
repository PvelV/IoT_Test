using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IoT_Test.API
{
    public class AppDatabase : DbContext
    { 
            DbSet<Message> Messages { get; }

    }
}