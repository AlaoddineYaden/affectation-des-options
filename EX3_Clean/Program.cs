using System;
using System.Collections.Generic;

namespace EX3_Clean
{

    class Program
    {
        static void Main(string[] args)
        {
            Options options = new Options();

            var etudiants = new List<Etudiant>() {
                new Etudiant(1,"alaoddine yaden",19.50,new List<String>(){ options.o1, options.o2, options.o3 }),
                new Etudiant(2,"hamza howani",19,new List<String>(){ options.o1, options.o3, options.o2 }),
                new Etudiant(3,"miko mako",18.50,new List<String>(){ options.o1, options.o2, options.o3 }),
                new Etudiant(4,"najib hajji",18,new List<String>(){ options.o1, options.o3, options.o2 }),
                new Etudiant(5,"salah howani",17.50,new List<String>(){ options.o1, options.o3, options.o2 }),
                new Etudiant(6,"kelvin klark",17,new List<String>(){ options.o1, options.o3, options.o2 }),
                new Etudiant(7,"lamiae kbbab",16.50,new List<String>(){ options.o1, options.o2, options.o3 }),
                new Etudiant(8,"jnnawi hamza",16,new List<String>(){ options.o1, options.o2, options.o3 }),
                new Etudiant(9,"hossam jibol",15.50,new List<String>(){ options.o1, options.o3, options.o2 })
            };
            Dictionary<int, string> liste1 = new Dictionary<int, string>();
            Dictionary<int, string> liste2 = new Dictionary<int, string>();
            Dictionary<int, string> liste3 = new Dictionary<int, string>();


            int i = 0;

            for (int y = 0; y < 3; y++)
            {
                foreach (var x in etudiants)
                {
                    if (x.Choix[y] == options.o1 && liste1.Count < 3 && liste1.ContainsKey(x.rate) == false && liste2.ContainsKey(x.rate) == false && liste3.ContainsKey(x.rate) == false)
                    {


                        string arr = x.NomPrenom + "\t" + x.Note;
                        liste1.Add(x.rate, arr);

                    }
                    else
                    {
                        if (x.Choix[y] == options.o2 && liste2.Count < 3 && liste1.ContainsKey(x.rate) == false && liste2.ContainsKey(x.rate) == false && liste3.ContainsKey(x.rate) == false)
                        {

                            string arr = x.NomPrenom + "\t" + x.Note;
                            liste2.Add(x.rate, arr);


                        }
                        else
                        {
                            if (x.Choix[y] == options.o3 && liste3.Count < 3 && liste1.ContainsKey(x.rate) == false && liste2.ContainsKey(x.rate) == false && liste3.ContainsKey(x.rate) == false)
                            {

                                string arr = x.NomPrenom + "\t" + x.Note;
                                liste3.Add(x.rate, arr);


                            }
                        }
                    }
                    i++;
                }
            }






            Console.WriteLine("liste GL");
            foreach (KeyValuePair<int, string> kvp in liste1)
                Console.WriteLine("\tEtudiant:\t{0}\t{1}", kvp.Key, kvp.Value);
            Console.WriteLine("liste ABD");
            foreach (KeyValuePair<int, string> kvp in liste2)
                Console.WriteLine("\tEtudiant:\t{0}\t{1}", kvp.Key, kvp.Value);
            Console.WriteLine("liste ASRL");
            foreach (KeyValuePair<int, string> kvp in liste3)
                Console.WriteLine("\tEtudiant:\t{0}\t{1}", kvp.Key, kvp.Value);

        }
    }
}
