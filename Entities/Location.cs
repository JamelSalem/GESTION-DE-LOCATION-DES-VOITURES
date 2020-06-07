//--------------- Code de la classe Location ---------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities
{
    public class Location
    {
        [Key]
        public int Num_Loc { get; set; }
        [ForeignKey("Voiture")]
        public string Immat_V { get; set; }
        [ForeignKey("Client")]
        public int Id_Cl { get; set; }
        public DateTime DDeb_Loc { get; set; }
        public DateTime DRet_Loc { get; set; }
        public Nullable<int> Kil_Dep { get; set; }
        public Nullable<int> Kil_Ret { get; set; }
        public Nullable<int> Nbj_Loc { get; set; }
        //Propriétés de navigation
        public virtual Client Client { get; set; }
        public virtual Voiture Voiture { get; set; }
    }
}
