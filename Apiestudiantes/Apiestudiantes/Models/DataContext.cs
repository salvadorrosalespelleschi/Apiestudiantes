﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Apiestudiantes.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<Apiestudiantes.Models.Student> Students { get; set; }
    }
}