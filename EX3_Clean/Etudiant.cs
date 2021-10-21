using System;
using System.Collections.Generic;
using System.Text;

namespace EX3_Clean
{
    class Etudiant
    {
        public int rate { get; set; }
        public String NomPrenom { get; set; }
        public double Note { get; set; }
        public List<String> Choix { get; set; }
        public Etudiant(int rat, String nom, double note, List<String> choix)
        {
            this.rate = rat;
            this.NomPrenom = nom;
            this.Note = note;
            this.Choix = choix;
        }
    }
}