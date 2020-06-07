using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace ClassesADO
{
    public class VoitureADO
    {
        // Ajout de nouvelle voiture
        public static void Ajouter(Voiture V)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                context.Voiture.Add(V);
                context.SaveChanges();
            }
        }
        // modifier les données d'une voiture existante
        public static void Modifier(Voiture V)
        {
            using (BDLocationEntities context = new BDLocationEntities())
            {
                Voiture oldVt = context.Voiture.Find(V.Immat_V);
                if (oldVt != null)
                {
                    oldVt.Marq_V = V.Marq_V;
                    oldVt.Mod_V = V.Mod_V;
                    oldVt.Kilom_V = V.Kilom_V;
                    oldVt.PrixLoc_V = V.PrixLoc_V;
                    oldVt.Est_Disp = V.Est_Disp;
                }
                context.SaveChanges();
            }
        }
        //supprimer une voiture ayant la matricule donnée en paramètre
        public static void Supprimer(string Mat)
    
{
using (BDLocationEntities context = new BDLocationEntities())
{
Voiture V = context.Voiture.Find(Mat);
if (V != null)
{
context.Voiture.Remove(V);
context.SaveChanges();
}
}
}
// Liste des voitures existantes triée par marque
public static List<Voiture> List_Voit()
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        var req = from c in context.Voiture
                  orderby c.Marq_V
                  select c;
        return req.ToList();
        // ou en syntaxe de méthode
        //return context.Voiture.OrderBy(v => v.Marq_V).ToList();
    }
}
// Liste des voitures disponibles
public static List<Voiture> List_Voit_Disp()
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        var req = from v in context.Voiture
                  where v.Est_Disp == true
                  orderby v.Marq_V ascending
                  select v;
        return req.ToList();
        // ou en syntaxe de méthode
        // return context.Voiture.Where(v => v.Est_Disp == true).OrderBy(v => v.Marq_V).ToList();
    }
}
// modifier la disponibilitée de la voiture en paramètre
public static void Modif_Disp(string Immat)
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        Voiture V = context.Voiture.Find(Immat);
        if (V != null)
        {
            V.Est_Disp = !V.Est_Disp;
            context.SaveChanges();
        }
    }
}
//Recherche des voitures d'une marque donnée
public static List<Voiture> Recherche_Marque(string marque)
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        return context.Voiture.Where
        (x => x.Marq_V.Contains(marque)).ToList();
    }
}
// recherche voiture par Immatriculation
public static Voiture Recherche_Immat(string immat)
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        return context.Voiture.Where
        (x => x.Immat_V == immat).SingleOrDefault();
    }
}
//Liste des voitures disponibles d'un modèle donné
public static List<Voiture> Recherche_modele_disp(string modele)
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        return context.Voiture.Where
        (x => x.Mod_V.Contains(modele) && x.Est_Disp == true)
        .OrderBy(x => x.Marq_V).ToList();
    }
}
// Liste des voitures disponibles d'une marque donnée
public static List<Voiture> Recherche_Marque_disp(string marque)
{
    using (BDLocationEntities context = new BDLocationEntities())
    {
        return context.Voiture.Where
        (x => x.Marq_V.Contains(marque) && x.Est_Disp == true)
        .OrderBy(x => x.Marq_V).ToList();
    }
}
}
}