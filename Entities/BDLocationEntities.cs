using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public class BDLocationEntities : DbContext
    {
        public BDLocationEntities() : base("name=BDLocationEntities")
        {
        }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Voiture> Voiture { get; set; }
    }
}
