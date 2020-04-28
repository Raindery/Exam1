using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exam
{
    class PhoneContext: DbContext
    {
        public PhoneContext() : base("PhoneDb")
        {
            
        }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Realization> Realizations { get; set; }

    }
}
