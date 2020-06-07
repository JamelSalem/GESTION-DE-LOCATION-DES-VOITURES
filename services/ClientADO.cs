// -------------Code de la classe ClientADO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ClassesADO
{
    public class ClientADO
    {
        public static void Ajouter(Client C)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                context.Client.Add(C);
                context.SaveChanges();
            }
        }
        public static void Modifier(Client C)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                Client Cl = context.Client.Find(C.Id_Cl);
                if (Cl != null)
                {
                    Cl.Nom_Cl = C.Nom_Cl;
                    Cl.Tel_Cl = C.Tel_Cl;
                    Cl.Adr_Cl = C.Adr_Cl;
                    Cl.Num_CIN = C.Num_CIN;
                }
                context.SaveChanges();
            }
        }
        public static void Supprimer(int Id)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                Client C = context.Client.Find(Id);
                if (C != null)
                {
                    context.Client.Remove(C);
                    context.SaveChanges();
                }
            }
        }
        public static List<Client> List_Client()
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                var req = from c in context.Client
                          orderby c.Nom_Cl
                          select c;
                // ou en syntaxe de méthode
                var req1 = context.Client.OrderBy(x => x.Nom_Cl);
                return req.ToList();
            }
        }
    }
}