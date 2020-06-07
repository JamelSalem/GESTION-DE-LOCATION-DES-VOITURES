//----------- Code de la classe Voiture ---------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public class Voiture
    {
        [Key]
        public string Immat_V { get; set; }
        public string Marq_V { get; set; }
        public string Mod_V { get; set; }
        public Nullable<int> Kilom_V { get; set; }
        public Nullable<double> PrixLoc_V { get; set; }
        public Nullable<bool> Est_Disp { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
