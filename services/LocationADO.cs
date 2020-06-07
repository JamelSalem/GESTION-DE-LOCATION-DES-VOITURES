using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace ClassesADO
{
    public class LocationADO
    {
        public static void Ajouter(Location LV)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                context.Location.Add(LV);
                context.SaveChanges();
            }
        }
        public static void Retourner_Loc(int Num, string Immat, int KR)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                var req1 = from l in context.Location
                           where l.Num_Loc == Num
            select l;
                Location L = req1.SingleOrDefault();
                // ou en syntaxe de méthode
                // Location L = context.Location.Where(x => x.Num_Loc == Num).SingleOrDefault();
                L.Kil_Ret = KR;
                var req2 = from v in context.Voiture
                           where v.Immat_V == Immat
                           select v;
                // ou en syntaxe de méthode
                Voiture v1 = context.Voiture.Where(x => x.Immat_V == Immat).SingleOrDefault();
                Voiture V = req2.SingleOrDefault();
                V.Est_Disp = true;
                V.Kilom_V = KR;
                context.SaveChanges();
            }
        }
        //Liste des locations en cours d'un client
        public static List<Location> List_Loc_Cl(int CodeCl)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                List<Location> L = (from l in context.Location
                                    where l.Id_Cl == CodeCl && l.Kil_Ret == null
                                    && l.DRet_Loc <= DateTime.Now
                                    orderby l.DDeb_Loc
                                    select l).ToList();
                return L;
            }
        }
        //Liste des locations en cours d'une voiture
        public static List<Location> List_Loc_Vt(string Immat)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                List<Location> L = (from l in context.Location
                                    where l.Immat_V == Immat && l.Kil_Ret == null
                                    && l.DRet_Loc <= DateTime.Now
                                    orderby l.DDeb_Loc
                                    select l).ToList();
                return L;
            }
        }
    }
}
