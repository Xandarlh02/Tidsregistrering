using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tidsreg_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Tidsreg_Api.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<RegistreringsModel> registrering { get; set; }
        public DBContext() : base()
        {
        }
    }
}