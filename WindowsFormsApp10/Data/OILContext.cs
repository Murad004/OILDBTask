using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp10.Model;

namespace WindowsFormsApp10.Data
{
    class OILContext:DbContext
    {
        public OILContext() : base("OILDb")
        {

        }
        public DbSet<OIL> OILS { get; set; }
    }
}
