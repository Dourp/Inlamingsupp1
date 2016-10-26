using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Inlämningsupp1.Models
{
    public class PeopleContext: DbContext
    {
        public DbSet<People> people { get; set; }
    }
}
